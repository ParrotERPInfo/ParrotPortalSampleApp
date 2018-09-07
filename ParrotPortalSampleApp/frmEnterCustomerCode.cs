using System;
using System.Windows.Forms;

namespace ParrotPortalSampleApp
{
    public partial class frmEnterCustomerCode : Form
    {
        /// <summary>
        /// Gets the entered Customer Code
        /// </summary>
        public string CustomerCode => txtCustCode.Text;

        public frmEnterCustomerCode()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for when the OK Button is clicked.
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            ParrotPortal.LastUsedCustomerCode = txtCustCode.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Event handler for when the Enter Customer Code form is loaded.
        /// </summary>
        private void frmEnterCustomerCode_Load(object sender, EventArgs e) => txtCustCode.Text = ParrotPortal.LastUsedCustomerCode;
    }
}
