
namespace Product_Management
{
    partial class frm_ProductDetails
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ProductDetails));
            this.patientDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalManagementDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_ProductDetails = new System.Windows.Forms.DataGridView();
            this.productNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mfgDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_Management_DBDataSet = new Product_Management.Product_Management_DBDataSet();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.btn_UpdateInformation = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.product_DetailsTableAdapter = new Product_Management.Product_Management_DBDataSetTableAdapters.Product_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Management_DBDataSet)).BeginInit();
            this.pnl_Menu.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // patientDetailsBindingSource
            // 
            this.patientDetailsBindingSource.DataMember = "Patient_Details";
            // 
            // dgv_ProductDetails
            // 
            this.dgv_ProductDetails.AutoGenerateColumns = false;
            this.dgv_ProductDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ProductDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProductDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.buyPriceDataGridViewTextBoxColumn,
            this.sellPriceDataGridViewTextBoxColumn,
            this.mfgDateDataGridViewTextBoxColumn,
            this.expDateDataGridViewTextBoxColumn});
            this.dgv_ProductDetails.DataSource = this.productDetailsBindingSource;
            this.dgv_ProductDetails.Location = new System.Drawing.Point(261, 130);
            this.dgv_ProductDetails.Name = "dgv_ProductDetails";
            this.dgv_ProductDetails.RowHeadersWidth = 62;
            this.dgv_ProductDetails.RowTemplate.Height = 28;
            this.dgv_ProductDetails.Size = new System.Drawing.Size(830, 464);
            this.dgv_ProductDetails.TabIndex = 36;
            // 
            // productNoDataGridViewTextBoxColumn
            // 
            this.productNoDataGridViewTextBoxColumn.DataPropertyName = "Product_No";
            this.productNoDataGridViewTextBoxColumn.HeaderText = "Product_No";
            this.productNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productNoDataGridViewTextBoxColumn.Name = "productNoDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // buyPriceDataGridViewTextBoxColumn
            // 
            this.buyPriceDataGridViewTextBoxColumn.DataPropertyName = "Buy_Price";
            this.buyPriceDataGridViewTextBoxColumn.HeaderText = "Buy_Price";
            this.buyPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.buyPriceDataGridViewTextBoxColumn.Name = "buyPriceDataGridViewTextBoxColumn";
            // 
            // sellPriceDataGridViewTextBoxColumn
            // 
            this.sellPriceDataGridViewTextBoxColumn.DataPropertyName = "Sell_Price ";
            this.sellPriceDataGridViewTextBoxColumn.HeaderText = "Sell_Price ";
            this.sellPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sellPriceDataGridViewTextBoxColumn.Name = "sellPriceDataGridViewTextBoxColumn";
            // 
            // mfgDateDataGridViewTextBoxColumn
            // 
            this.mfgDateDataGridViewTextBoxColumn.DataPropertyName = "Mfg_Date";
            this.mfgDateDataGridViewTextBoxColumn.HeaderText = "Mfg_Date";
            this.mfgDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mfgDateDataGridViewTextBoxColumn.Name = "mfgDateDataGridViewTextBoxColumn";
            // 
            // expDateDataGridViewTextBoxColumn
            // 
            this.expDateDataGridViewTextBoxColumn.DataPropertyName = "Exp_Date";
            this.expDateDataGridViewTextBoxColumn.HeaderText = "Exp_Date";
            this.expDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.expDateDataGridViewTextBoxColumn.Name = "expDateDataGridViewTextBoxColumn";
            // 
            // productDetailsBindingSource
            // 
            this.productDetailsBindingSource.DataMember = "Product_Details";
            this.productDetailsBindingSource.DataSource = this.product_Management_DBDataSet;
            // 
            // product_Management_DBDataSet
            // 
            this.product_Management_DBDataSet.DataSetName = "Product_Management_DBDataSet";
            this.product_Management_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.Linen;
            this.pnl_Menu.Controls.Add(this.lbl_welcome);
            this.pnl_Menu.Controls.Add(this.btn_Search);
            this.pnl_Menu.Controls.Add(this.btn_Logout);
            this.pnl_Menu.Controls.Add(this.btn_AddProduct);
            this.pnl_Menu.Controls.Add(this.btn_UpdateInformation);
            this.pnl_Menu.Controls.Add(this.btn_Close);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 130);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(261, 464);
            this.pnl_Menu.TabIndex = 83;
            this.pnl_Menu.TabStop = true;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.BackColor = System.Drawing.Color.Tan;
            this.lbl_welcome.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(5, 4);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(94, 24);
            this.lbl_welcome.TabIndex = 28;
            this.lbl_welcome.Text = "Welcome";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Gray;
            this.btn_Search.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Search.Location = new System.Drawing.Point(19, 125);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(225, 52);
            this.btn_Search.TabIndex = 56;
            this.btn_Search.Text = "Search Product";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Gray;
            this.btn_Logout.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Logout.Location = new System.Drawing.Point(19, 369);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(225, 47);
            this.btn_Logout.TabIndex = 5367;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.BackColor = System.Drawing.Color.Gray;
            this.btn_AddProduct.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddProduct.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_AddProduct.Location = new System.Drawing.Point(19, 45);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(225, 52);
            this.btn_AddProduct.TabIndex = 55;
            this.btn_AddProduct.Text = "Add Product";
            this.btn_AddProduct.UseVisualStyleBackColor = false;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // btn_UpdateInformation
            // 
            this.btn_UpdateInformation.BackColor = System.Drawing.Color.Gray;
            this.btn_UpdateInformation.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateInformation.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_UpdateInformation.Location = new System.Drawing.Point(19, 207);
            this.btn_UpdateInformation.Name = "btn_UpdateInformation";
            this.btn_UpdateInformation.Size = new System.Drawing.Size(225, 52);
            this.btn_UpdateInformation.TabIndex = 57;
            this.btn_UpdateInformation.Text = "Update Info";
            this.btn_UpdateInformation.UseVisualStyleBackColor = false;
            this.btn_UpdateInformation.Click += new System.EventHandler(this.btn_UpdateInformation_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Gray;
            this.btn_Close.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Close.Location = new System.Drawing.Point(19, 288);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(225, 52);
            this.btn_Close.TabIndex = 56;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // pnl_Header
            // 
            this.pnl_Header.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_Header.BackColor = System.Drawing.Color.Linen;
            this.pnl_Header.Controls.Add(this.pb_Logo);
            this.pnl_Header.Controls.Add(this.lbl_Header);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1078, 130);
            this.pnl_Header.TabIndex = 82;
            // 
            // pb_Logo
            // 
            this.pb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logo.Image")));
            this.pb_Logo.Location = new System.Drawing.Point(4, 4);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(257, 126);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logo.TabIndex = 1;
            this.pb_Logo.TabStop = false;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.Linen;
            this.lbl_Header.Font = new System.Drawing.Font("Georgia", 38F);
            this.lbl_Header.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Header.Location = new System.Drawing.Point(383, 22);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(557, 87);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Product Details";
            // 
            // product_DetailsTableAdapter
            // 
            this.product_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 594);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.dgv_ProductDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ProductDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Details";
            this.Load += new System.EventHandler(this.frm_ProductDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Management_DBDataSet)).EndInit();
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Menu.PerformLayout();
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource patientDetailsBindingSource;
        private System.Windows.Forms.BindingSource hospitalManagementDBDataSetBindingSource;
        private System.Windows.Forms.DataGridView dgv_ProductDetails;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.Button btn_UpdateInformation;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Label lbl_Header;
        private Product_Management_DBDataSet product_Management_DBDataSet;
        private System.Windows.Forms.BindingSource productDetailsBindingSource;
        private Product_Management_DBDataSetTableAdapters.Product_DetailsTableAdapter product_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mfgDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expDateDataGridViewTextBoxColumn;
    }
}