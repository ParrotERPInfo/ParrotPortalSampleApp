using ParrotPortalSampleApp.WCF.ProductInfo;
using System;
using System.Configuration;
using System.ServiceModel;

namespace ParrotPortalSampleApp
{

    /// <summary>
    /// Global class which handles attempting to connect to the Parrot Portal and return Product results.
    /// </summary>
    internal static class ParrotPortal
    {

        /// <summary>
        /// Gets the Server Url (if in dev mode, localhost, else live server)
        /// </summary>
        public static string ServerUrl
        {
            get
            {
                if (bool.Parse(ConfigurationManager.AppSettings["IsDevMode"])) return "https://localhost/Portal/ProductInfo.svc/basic";
                return "https://accounts.parrotproducts.biz/Portal/ProductInfo.svc/basic";
            }
        }

        /// <summary>
        /// Gets/sets the Last Used Customer Code.
        /// </summary>
        public static string LastUsedCustomerCode { get; set; } = string.Empty;

        /// <summary>
        /// Attempts to connect to the Parrot Portal and return a Portal Result with a List of Product Information.
        /// </summary>
        public static PortalResultOfArrayOfProductInformationAmSG9_SwV TryConnectAndReturnProducts(string UserName, string Password, string PortalPassword, string CustomerCode)
        {
            var endPointAddress = new EndpointAddress(ServerUrl);
            var client = new ProductInfoClient(CreateServiceBinding(), endPointAddress);
            //if portal password's null use same password as the user password
            if (string.IsNullOrWhiteSpace(PortalPassword)) PortalPassword = Password;

            client.ClientCredentials.UserName.UserName = UserName;
            client.ClientCredentials.UserName.Password = Password;
            try //call the web service, fetching all products
            {
                var result =  client.GetProductInfoForCustomerForMultipleProductsUsingDefaults(null, CustomerCode, PortalPassword, false);
                return result;
            }
            catch (Exception ex)
            {
                return new PortalResultOfArrayOfProductInformationAmSG9_SwV() { Message = ex.Message } ;
            }
        }

        /// <summary>
        /// Creates a HTTPS <see cref="BasicHttpBinding"/> to call the Product Info Service with.
        /// </summary>
        private static BasicHttpBinding CreateServiceBinding()
        {
            //set SecurityMode to 'Transport' (HTTPS)
            var binding = new BasicHttpBinding(BasicHttpSecurityMode.Transport) //set binding buffers to Maximum and tranpsort security to Basic
            {
                MaxBufferSize = int.MaxValue,
                MaxBufferPoolSize = int.MaxValue,
                MaxReceivedMessageSize = int.MaxValue
            };
            binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
            return binding;
        }
    }
}