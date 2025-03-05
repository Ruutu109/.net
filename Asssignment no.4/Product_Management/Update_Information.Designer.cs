
namespace Product_Management
{
    partial class frm_UpdateInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UpdateInformation));
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_ProductDetails = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.tb_BuyPrice = new System.Windows.Forms.TextBox();
            this.dtp_MfgDate = new System.Windows.Forms.DateTimePicker();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.tb_SellPrice = new System.Windows.Forms.TextBox();
            this.lbl_SellPrice = new System.Windows.Forms.Label();
            this.lbl_BuyPrice = new System.Windows.Forms.Label();
            this.dtp_ExpDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_ExrDate = new System.Windows.Forms.Label();
            this.tb_ProductNo = new System.Windows.Forms.TextBox();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.lbl_ProductNo = new System.Windows.Forms.Label();
            this.lbl_MfgDate = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.pnl_Menu.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.Linen;
            this.pnl_Menu.Controls.Add(this.lbl_welcome);
            this.pnl_Menu.Controls.Add(this.btn_AddProduct);
            this.pnl_Menu.Controls.Add(this.btn_Logout);
            this.pnl_Menu.Controls.Add(this.btn_ProductDetails);
            this.pnl_Menu.Controls.Add(this.btn_Refresh);
            this.pnl_Menu.Controls.Add(this.btn_Close);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 130);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(261, 464);
            this.pnl_Menu.TabIndex = 96;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.BackColor = System.Drawing.Color.Tan;
            this.lbl_welcome.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(5, 4);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(0, 24);
            this.lbl_welcome.TabIndex = 28;
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.BackColor = System.Drawing.Color.Gray;
            this.btn_AddProduct.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddProduct.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_AddProduct.Location = new System.Drawing.Point(19, 125);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(225, 52);
            this.btn_AddProduct.TabIndex = 4;
            this.btn_AddProduct.Text = "Add Product";
            this.btn_AddProduct.UseVisualStyleBackColor = false;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Gray;
            this.btn_Logout.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Logout.Location = new System.Drawing.Point(19, 369);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(225, 52);
            this.btn_Logout.TabIndex = 7;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_ProductDetails
            // 
            this.btn_ProductDetails.BackColor = System.Drawing.Color.Gray;
            this.btn_ProductDetails.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProductDetails.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_ProductDetails.Location = new System.Drawing.Point(19, 45);
            this.btn_ProductDetails.Name = "btn_ProductDetails";
            this.btn_ProductDetails.Size = new System.Drawing.Size(225, 52);
            this.btn_ProductDetails.TabIndex = 3;
            this.btn_ProductDetails.Text = "Product Details";
            this.btn_ProductDetails.UseVisualStyleBackColor = false;
            this.btn_ProductDetails.Click += new System.EventHandler(this.btn_ProductDetails_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Gray;
            this.btn_Refresh.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Refresh.Location = new System.Drawing.Point(19, 207);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(225, 52);
            this.btn_Refresh.TabIndex = 5;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Gray;
            this.btn_Close.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Close.Location = new System.Drawing.Point(19, 287);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(225, 52);
            this.btn_Close.TabIndex = 6;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // tb_BuyPrice
            // 
            this.tb_BuyPrice.Enabled = false;
            this.tb_BuyPrice.Font = new System.Drawing.Font("Georgia", 14F);
            this.tb_BuyPrice.Location = new System.Drawing.Point(645, 293);
            this.tb_BuyPrice.MaxLength = 9;
            this.tb_BuyPrice.Name = "tb_BuyPrice";
            this.tb_BuyPrice.Size = new System.Drawing.Size(337, 39);
            this.tb_BuyPrice.TabIndex = 93;
            this.tb_BuyPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Number);
            // 
            // dtp_MfgDate
            // 
            this.dtp_MfgDate.Enabled = false;
            this.dtp_MfgDate.Font = new System.Drawing.Font("Georgia", 14F);
            this.dtp_MfgDate.Location = new System.Drawing.Point(645, 411);
            this.dtp_MfgDate.Name = "dtp_MfgDate";
            this.dtp_MfgDate.Size = new System.Drawing.Size(337, 39);
            this.dtp_MfgDate.TabIndex = 86;
            // 
            // tb_Name
            // 
            this.tb_Name.Enabled = false;
            this.tb_Name.Font = new System.Drawing.Font("Georgia", 14F);
            this.tb_Name.Location = new System.Drawing.Point(645, 234);
            this.tb_Name.MaxLength = 45;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(337, 39);
            this.tb_Name.TabIndex = 84;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Georgia", 14F);
            this.lbl_Name.Location = new System.Drawing.Point(329, 237);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(89, 32);
            this.lbl_Name.TabIndex = 88;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.Linen;
            this.lbl_Header.Font = new System.Drawing.Font("Georgia", 38F);
            this.lbl_Header.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_Header.Location = new System.Drawing.Point(303, 20);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(726, 87);
            this.lbl_Header.TabIndex = 2223;
            this.lbl_Header.Text = "Update Product Info";
            // 
            // tb_SellPrice
            // 
            this.tb_SellPrice.Enabled = false;
            this.tb_SellPrice.Font = new System.Drawing.Font("Georgia", 14F);
            this.tb_SellPrice.Location = new System.Drawing.Point(645, 352);
            this.tb_SellPrice.MaxLength = 9;
            this.tb_SellPrice.Name = "tb_SellPrice";
            this.tb_SellPrice.Size = new System.Drawing.Size(337, 39);
            this.tb_SellPrice.TabIndex = 95;
            this.tb_SellPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Number);
            // 
            // lbl_SellPrice
            // 
            this.lbl_SellPrice.AutoSize = true;
            this.lbl_SellPrice.Font = new System.Drawing.Font("Georgia", 14F);
            this.lbl_SellPrice.Location = new System.Drawing.Point(329, 355);
            this.lbl_SellPrice.Name = "lbl_SellPrice";
            this.lbl_SellPrice.Size = new System.Drawing.Size(170, 32);
            this.lbl_SellPrice.TabIndex = 94;
            this.lbl_SellPrice.Text = "Selling Price";
            // 
            // lbl_BuyPrice
            // 
            this.lbl_BuyPrice.AutoSize = true;
            this.lbl_BuyPrice.Font = new System.Drawing.Font("Georgia", 14F);
            this.lbl_BuyPrice.Location = new System.Drawing.Point(329, 296);
            this.lbl_BuyPrice.Name = "lbl_BuyPrice";
            this.lbl_BuyPrice.Size = new System.Drawing.Size(173, 32);
            this.lbl_BuyPrice.TabIndex = 92;
            this.lbl_BuyPrice.Text = "Buying Price";
            // 
            // dtp_ExpDate
            // 
            this.dtp_ExpDate.Enabled = false;
            this.dtp_ExpDate.Font = new System.Drawing.Font("Georgia", 14F);
            this.dtp_ExpDate.Location = new System.Drawing.Point(645, 470);
            this.dtp_ExpDate.Name = "dtp_ExpDate";
            this.dtp_ExpDate.Size = new System.Drawing.Size(337, 39);
            this.dtp_ExpDate.TabIndex = 91;
            // 
            // lbl_ExrDate
            // 
            this.lbl_ExrDate.AutoSize = true;
            this.lbl_ExrDate.Font = new System.Drawing.Font("Georgia", 14F);
            this.lbl_ExrDate.Location = new System.Drawing.Point(329, 475);
            this.lbl_ExrDate.Name = "lbl_ExrDate";
            this.lbl_ExrDate.Size = new System.Drawing.Size(162, 32);
            this.lbl_ExrDate.TabIndex = 90;
            this.lbl_ExrDate.Text = "Expiry Date";
            // 
            // tb_ProductNo
            // 
            this.tb_ProductNo.Font = new System.Drawing.Font("Georgia", 14F);
            this.tb_ProductNo.Location = new System.Drawing.Point(645, 175);
            this.tb_ProductNo.MaxLength = 1;
            this.tb_ProductNo.Name = "tb_ProductNo";
            this.tb_ProductNo.Size = new System.Drawing.Size(337, 39);
            this.tb_ProductNo.TabIndex = 82;
            this.tb_ProductNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Number);
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
            this.pnl_Header.TabIndex = 89;
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
            // lbl_ProductNo
            // 
            this.lbl_ProductNo.AutoSize = true;
            this.lbl_ProductNo.Font = new System.Drawing.Font("Georgia", 14F);
            this.lbl_ProductNo.Location = new System.Drawing.Point(329, 178);
            this.lbl_ProductNo.Name = "lbl_ProductNo";
            this.lbl_ProductNo.Size = new System.Drawing.Size(165, 32);
            this.lbl_ProductNo.TabIndex = 85;
            this.lbl_ProductNo.Text = "Product No.";
            // 
            // lbl_MfgDate
            // 
            this.lbl_MfgDate.AutoSize = true;
            this.lbl_MfgDate.Font = new System.Drawing.Font("Georgia", 14F);
            this.lbl_MfgDate.Location = new System.Drawing.Point(329, 416);
            this.lbl_MfgDate.Name = "lbl_MfgDate";
            this.lbl_MfgDate.Size = new System.Drawing.Size(268, 32);
            this.lbl_MfgDate.TabIndex = 87;
            this.lbl_MfgDate.Text = "Manufacturing Date";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Search.BackgroundImage")));
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Search.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_Search.Location = new System.Drawing.Point(1011, 173);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(41, 41);
            this.btn_Search.TabIndex = 83;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Gray;
            this.btn_Update.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Update.Location = new System.Drawing.Point(528, 530);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(225, 52);
            this.btn_Update.TabIndex = 97;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // frm_UpdateInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1078, 594);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.tb_BuyPrice);
            this.Controls.Add(this.dtp_MfgDate);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.tb_SellPrice);
            this.Controls.Add(this.lbl_SellPrice);
            this.Controls.Add(this.lbl_BuyPrice);
            this.Controls.Add(this.dtp_ExpDate);
            this.Controls.Add(this.lbl_ExrDate);
            this.Controls.Add(this.tb_ProductNo);
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.lbl_ProductNo);
            this.Controls.Add(this.lbl_MfgDate);
            this.Controls.Add(this.btn_Search);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_UpdateInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Information";
            this.Load += new System.EventHandler(this.frm_UpdateInformation_Load);
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Menu.PerformLayout();
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_ProductDetails;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.TextBox tb_BuyPrice;
        private System.Windows.Forms.DateTimePicker dtp_MfgDate;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.TextBox tb_SellPrice;
        private System.Windows.Forms.Label lbl_SellPrice;
        private System.Windows.Forms.Label lbl_BuyPrice;
        private System.Windows.Forms.DateTimePicker dtp_ExpDate;
        private System.Windows.Forms.Label lbl_ExrDate;
        private System.Windows.Forms.TextBox tb_ProductNo;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Label lbl_ProductNo;
        private System.Windows.Forms.Label lbl_MfgDate;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Update;
    }
}