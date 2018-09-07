using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ParrotPortalSampleApp.WCF.ParrotProductInfo;

namespace ParrotPortalSampleApp
{
    public partial class frmMain : Form
    {
        private List<ProductInformation> m_BindingList = null;
        private int m_SelectedRow = -1;
        public frmMain()
        {
            InitializeComponent();
            dtgvProducts.AutoGenerateColumns = false;
            lblInfo.Text += ParrotPortal.ServerUrl;
        }

        /// <summary>
        /// Event handler for when the Test button is clicked.
        /// </summary>
        private void btnTest_Click(object sender, EventArgs e)
        {
            //reset list and selected row
            m_SelectedRow = -1;
            m_BindingList = null;
            dtgvProducts.DataSource = null;
            pbProductImage.Visible = false;

            //customer code prompt
            var enterCode = new frmEnterCustomerCode();
            enterCode.FormBorderStyle = FormBorderStyle.FixedSingle;
            enterCode.MinimizeBox = false;
            enterCode.MaximizeBox = false;
            enterCode.StartPosition = FormStartPosition.CenterParent;
            var dailogResult = enterCode.ShowDialog();

            if (string.IsNullOrWhiteSpace(enterCode.CustomerCode) & dailogResult == DialogResult.OK)
            {
                Cursor = Cursors.Default;
                MessageBox.Show("Cannot fetch information if the Customer Code is blank!", "Customer Code is blank", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (dailogResult == DialogResult.Cancel)
            {
                return;
            }


            Cursor = Cursors.WaitCursor;
            PortalResultOfArrayOfProductInformationAmSG9_SwV result = ParrotPortal.TryConnectAndReturnProducts(txtUsername.Text, txtPassword.Text, txtPortalPass.Text, enterCode.CustomerCode);

            //get the data object (which is a list of Product Information) and bind it to the DataGridView
            if (result.Data?.Count > 0)
            {
                m_BindingList = result.Data;
                dtgvProducts.DataSource = m_BindingList;
            }
            else //display message from the result object (will either be a connection error or server error)
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor = Cursors.Default;

            //select first row so image loads
            if (m_BindingList?.Count > 0)
            {
                int firstItem = 0;
                dtgvProducts.Rows[firstItem].Selected = true;
                m_SelectedRow = firstItem;
                DisplayPictureForRow();
            }
        }

        /// <summary>
        /// Event handler for when the Same Password checkbox is changed
        /// </summary>
        private void chkSamePass_CheckedChanged(object sender, EventArgs e)
        {
            lblPortalPass.Visible = !chkSamePass.Checked;
            txtPortalPass.Visible = !chkSamePass.Checked;
            if (chkSamePass.Checked == true) txtPortalPass.Text = string.Empty;
        }

        /// <summary>
        /// Displays the Picture for the Selected Row in the Picture Box (if one exists)
        /// </summary>
        private void DisplayPictureForRow()
        {
            if (m_BindingList[m_SelectedRow].ProductImageLinks?.Count > 0)
            {
                pbProductImage.Visible = true;
                pbProductImage.ImageLocation = m_BindingList[m_SelectedRow].ProductImageLinks.FirstOrDefault();
                pbProductImage.Load();
            }
            else
            {
                pbProductImage.Visible = false;
            }
        }

        /// <summary>
        /// Event handler for when the datagridview's row selection is changed.
        /// </summary>
        private void dtgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvProducts.CurrentRow.Index != m_SelectedRow)
            {
                m_SelectedRow = dtgvProducts.CurrentRow.Index;
                if (m_SelectedRow <= m_BindingList?.Count - 1)
                {
                    DisplayPictureForRow();
                }
                else
                {
                    pbProductImage.Visible = false;
                }
            }
        }
    }
}