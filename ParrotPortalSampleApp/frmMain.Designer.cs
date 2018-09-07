namespace ParrotPortalSampleApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutPnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.layoutPnlTop = new System.Windows.Forms.TableLayoutPanel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.layoutPnlDetails = new System.Windows.Forms.TableLayoutPanel();
            this.txtPortalPass = new System.Windows.Forms.TextBox();
            this.lblPortalPass = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.flowLayoutPnlRight = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTest = new System.Windows.Forms.Button();
            this.chkSamePass = new System.Windows.Forms.CheckBox();
            this.dtgvProducts = new System.Windows.Forms.DataGridView();
            this.StockCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerTaxAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerPriceWithTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductBarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlImageInfo = new System.Windows.Forms.Panel();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.layoutPnlMain.SuspendLayout();
            this.layoutPnlTop.SuspendLayout();
            this.layoutPnlDetails.SuspendLayout();
            this.flowLayoutPnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProducts)).BeginInit();
            this.pnlImageInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutPnlMain
            // 
            this.layoutPnlMain.AutoScroll = true;
            this.layoutPnlMain.ColumnCount = 1;
            this.layoutPnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPnlMain.Controls.Add(this.layoutPnlTop, 0, 0);
            this.layoutPnlMain.Controls.Add(this.dtgvProducts, 0, 1);
            this.layoutPnlMain.Controls.Add(this.pnlImageInfo, 0, 2);
            this.layoutPnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPnlMain.Location = new System.Drawing.Point(0, 0);
            this.layoutPnlMain.Name = "layoutPnlMain";
            this.layoutPnlMain.RowCount = 3;
            this.layoutPnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.layoutPnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPnlMain.Size = new System.Drawing.Size(848, 496);
            this.layoutPnlMain.TabIndex = 0;
            // 
            // layoutPnlTop
            // 
            this.layoutPnlTop.AutoScroll = true;
            this.layoutPnlTop.ColumnCount = 2;
            this.layoutPnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPnlTop.Controls.Add(this.lblInfo, 0, 0);
            this.layoutPnlTop.Controls.Add(this.layoutPnlDetails, 0, 1);
            this.layoutPnlTop.Controls.Add(this.flowLayoutPnlRight, 1, 1);
            this.layoutPnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPnlTop.Location = new System.Drawing.Point(3, 3);
            this.layoutPnlTop.Name = "layoutPnlTop";
            this.layoutPnlTop.RowCount = 2;
            this.layoutPnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPnlTop.Size = new System.Drawing.Size(842, 124);
            this.layoutPnlTop.TabIndex = 3;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.layoutPnlTop.SetColumnSpan(this.lblInfo, 2);
            this.lblInfo.Location = new System.Drawing.Point(3, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(795, 26);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Click on the test button to attempt to Connect to the Parrot Portal and retreive " +
    "Product Information, after entering in your Username and Pasword below. The test" +
    " will be performed to: ";
            // 
            // layoutPnlDetails
            // 
            this.layoutPnlDetails.AutoScroll = true;
            this.layoutPnlDetails.ColumnCount = 2;
            this.layoutPnlDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.layoutPnlDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPnlDetails.Controls.Add(this.txtPortalPass, 1, 2);
            this.layoutPnlDetails.Controls.Add(this.lblPortalPass, 0, 2);
            this.layoutPnlDetails.Controls.Add(this.lblUsername, 0, 0);
            this.layoutPnlDetails.Controls.Add(this.txtUsername, 1, 0);
            this.layoutPnlDetails.Controls.Add(this.txtPassword, 1, 1);
            this.layoutPnlDetails.Controls.Add(this.lblPassword, 0, 1);
            this.layoutPnlDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPnlDetails.Location = new System.Drawing.Point(3, 29);
            this.layoutPnlDetails.Name = "layoutPnlDetails";
            this.layoutPnlDetails.RowCount = 3;
            this.layoutPnlDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutPnlDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutPnlDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutPnlDetails.Size = new System.Drawing.Size(415, 92);
            this.layoutPnlDetails.TabIndex = 2;
            // 
            // txtPortalPass
            // 
            this.txtPortalPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPortalPass.Location = new System.Drawing.Point(123, 63);
            this.txtPortalPass.Name = "txtPortalPass";
            this.txtPortalPass.Size = new System.Drawing.Size(289, 20);
            this.txtPortalPass.TabIndex = 5;
            this.txtPortalPass.UseSystemPasswordChar = true;
            this.txtPortalPass.Visible = false;
            // 
            // lblPortalPass
            // 
            this.lblPortalPass.AutoSize = true;
            this.lblPortalPass.Location = new System.Drawing.Point(3, 60);
            this.lblPortalPass.Name = "lblPortalPass";
            this.lblPortalPass.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblPortalPass.Size = new System.Drawing.Size(86, 18);
            this.lblPortalPass.TabIndex = 4;
            this.lblPortalPass.Text = "Portal Password:";
            this.lblPortalPass.Visible = false;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(3, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblUsername.Size = new System.Drawing.Size(58, 30);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsername.Location = new System.Drawing.Point(123, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(289, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Location = new System.Drawing.Point(123, 33);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(289, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(3, 30);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblPassword.Size = new System.Drawing.Size(56, 18);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // flowLayoutPnlRight
            // 
            this.flowLayoutPnlRight.Controls.Add(this.btnTest);
            this.flowLayoutPnlRight.Controls.Add(this.chkSamePass);
            this.flowLayoutPnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPnlRight.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPnlRight.Location = new System.Drawing.Point(424, 29);
            this.flowLayoutPnlRight.Name = "flowLayoutPnlRight";
            this.flowLayoutPnlRight.Size = new System.Drawing.Size(415, 92);
            this.flowLayoutPnlRight.TabIndex = 3;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(3, 3);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // chkSamePass
            // 
            this.chkSamePass.AutoSize = true;
            this.chkSamePass.Checked = true;
            this.chkSamePass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSamePass.Location = new System.Drawing.Point(3, 32);
            this.chkSamePass.Name = "chkSamePass";
            this.chkSamePass.Size = new System.Drawing.Size(227, 17);
            this.chkSamePass.TabIndex = 3;
            this.chkSamePass.Text = "User password and Portal password match";
            this.chkSamePass.UseVisualStyleBackColor = true;
            this.chkSamePass.CheckedChanged += new System.EventHandler(this.chkSamePass_CheckedChanged);
            // 
            // dtgvProducts
            // 
            this.dtgvProducts.AllowUserToAddRows = false;
            this.dtgvProducts.AllowUserToDeleteRows = false;
            this.dtgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockCode,
            this.Description,
            this.CustomerPrice,
            this.CustomerTaxAmount,
            this.CustomerPriceWithTax,
            this.ProductBarCode,
            this.RetailPrice});
            this.dtgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvProducts.Location = new System.Drawing.Point(3, 133);
            this.dtgvProducts.MaximumSize = new System.Drawing.Size(945, 124);
            this.dtgvProducts.MinimumSize = new System.Drawing.Size(745, 124);
            this.dtgvProducts.MultiSelect = false;
            this.dtgvProducts.Name = "dtgvProducts";
            this.dtgvProducts.ReadOnly = true;
            this.dtgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvProducts.Size = new System.Drawing.Size(842, 124);
            this.dtgvProducts.TabIndex = 1;
            this.dtgvProducts.SelectionChanged += new System.EventHandler(this.dtgvProducts_SelectionChanged);
            // 
            // StockCode
            // 
            this.StockCode.DataPropertyName = "StockCode";
            this.StockCode.HeaderText = "Stock Code";
            this.StockCode.Name = "StockCode";
            this.StockCode.ReadOnly = true;
            this.StockCode.Width = 81;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 85;
            // 
            // CustomerPrice
            // 
            this.CustomerPrice.DataPropertyName = "CustomerPrice";
            this.CustomerPrice.HeaderText = "Customer Price";
            this.CustomerPrice.Name = "CustomerPrice";
            this.CustomerPrice.ReadOnly = true;
            this.CustomerPrice.Width = 95;
            // 
            // CustomerTaxAmount
            // 
            this.CustomerTaxAmount.DataPropertyName = "CustomerTaxAmount";
            this.CustomerTaxAmount.HeaderText = "Tax Amount";
            this.CustomerTaxAmount.Name = "CustomerTaxAmount";
            this.CustomerTaxAmount.ReadOnly = true;
            this.CustomerTaxAmount.Width = 82;
            // 
            // CustomerPriceWithTax
            // 
            this.CustomerPriceWithTax.DataPropertyName = "CustomerPriceWithTax";
            this.CustomerPriceWithTax.HeaderText = "Customer Price w/ Tax";
            this.CustomerPriceWithTax.Name = "CustomerPriceWithTax";
            this.CustomerPriceWithTax.ReadOnly = true;
            this.CustomerPriceWithTax.Width = 97;
            // 
            // ProductBarCode
            // 
            this.ProductBarCode.DataPropertyName = "ProductBarCode";
            this.ProductBarCode.HeaderText = "Bar Code";
            this.ProductBarCode.Name = "ProductBarCode";
            this.ProductBarCode.ReadOnly = true;
            this.ProductBarCode.Width = 70;
            // 
            // RetailPrice
            // 
            this.RetailPrice.DataPropertyName = "RetailPrice";
            this.RetailPrice.HeaderText = "RRP";
            this.RetailPrice.Name = "RetailPrice";
            this.RetailPrice.ReadOnly = true;
            this.RetailPrice.ToolTipText = "Recommended Retail Price";
            this.RetailPrice.Width = 55;
            // 
            // pnlImageInfo
            // 
            this.pnlImageInfo.AutoScroll = true;
            this.pnlImageInfo.Controls.Add(this.pbProductImage);
            this.pnlImageInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImageInfo.Location = new System.Drawing.Point(10, 270);
            this.pnlImageInfo.Margin = new System.Windows.Forms.Padding(10);
            this.pnlImageInfo.Name = "pnlImageInfo";
            this.pnlImageInfo.Size = new System.Drawing.Size(828, 216);
            this.pnlImageInfo.TabIndex = 4;
            // 
            // pbProductImage
            // 
            this.pbProductImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbProductImage.Location = new System.Drawing.Point(1, 2);
            this.pbProductImage.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(0, 230);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbProductImage.TabIndex = 7;
            this.pbProductImage.TabStop = false;
            this.pbProductImage.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 496);
            this.Controls.Add(this.layoutPnlMain);
            this.Name = "frmMain";
            this.Text = "Parrot Portal Sample Application";
            this.layoutPnlMain.ResumeLayout(false);
            this.layoutPnlTop.ResumeLayout(false);
            this.layoutPnlTop.PerformLayout();
            this.layoutPnlDetails.ResumeLayout(false);
            this.layoutPnlDetails.PerformLayout();
            this.flowLayoutPnlRight.ResumeLayout(false);
            this.flowLayoutPnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProducts)).EndInit();
            this.pnlImageInfo.ResumeLayout(false);
            this.pnlImageInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutPnlMain;
        private System.Windows.Forms.DataGridView dtgvProducts;
        private System.Windows.Forms.TableLayoutPanel layoutPnlTop;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TableLayoutPanel layoutPnlDetails;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerTaxAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerPriceWithTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductBarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetailPrice;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPnlRight;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.CheckBox chkSamePass;
        private System.Windows.Forms.TextBox txtPortalPass;
        private System.Windows.Forms.Label lblPortalPass;
        private System.Windows.Forms.Panel pnlImageInfo;
        private System.Windows.Forms.PictureBox pbProductImage;
    }
}

