using System;
using ParrotPortalSampleApp.WCF.ParrotProductInfo;
using System.ServiceModel;
using System.Configuration;

namespace ParrotPortalSampleApp
{

    /// <summary>
    /// Handles attempting to connect to the Parrot Portal and return Product results.
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
                if (bool.Parse(ConfigurationManager.AppSettings["IsDevMode"]))
                {
                    return "http://localhost/Portal/ProductInfo.svc/basic";
                }
                return "http://accounts.parrotproducts.biz/Portal/ProductInfo.svc/basic";
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
            var endpointConfigurationName = "BasicHttpEndpoint";

            var client = new ProductInfoClient(endpointConfigurationName, endPointAddress);

            //if portal password's null use same password as the user password
            if (string.IsNullOrWhiteSpace(PortalPassword)) PortalPassword = Password;

            client.ClientCredentials.UserName.UserName = UserName;
            client.ClientCredentials.UserName.Password = Password;
           
            try //call the web service
            {
                //all products
                var result = client.GetProductInfoForCustomerForMultipleProductsUsingDefaults(null, CustomerCode, PortalPassword, false);
                return result;
            }
            catch (Exception ex)
            {
                return new PortalResultOfArrayOfProductInformationAmSG9_SwV() { Message = ex.Message } ;
            }
        }
    }
}
