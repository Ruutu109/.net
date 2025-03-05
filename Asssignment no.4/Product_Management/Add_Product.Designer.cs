
namespace Product_Management
{
    partial class frm_AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddProduct));
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_ProductDetails = new System.Windows.Forms.Button();
            this.dtp_MfgDate = new System.Windows.Forms.DateTimePicker();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_ProductNo = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_AddProductDetails = new System.Windows.Forms.Label();
            this.lbl_MfgDate = new System.Windows.Forms.Label();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_ExrDate = new System.Windows.Forms.Label();
            this.dtp_ExpDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_BuyPrice = new System.Windows.Forms.Label();
            this.tb_ProductNo = new System.Windows.Forms.TextBox();
            this.lbl_SellPrice = new System.Windows.Forms.Label();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.btn_SearchPatient = new System.Windows.Forms.Button();
            this.tb_BuyPrice = new System.Windows.Forms.TextBox();
            this.tb_SellPrice = new System.Windows.Forms.TextBox();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Gray;
            this.btn_Close.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Close.Location = new System.Drawing.Point(19, 288);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(225, 52);
            this.btn_Close.TabIndex = 10;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Gray;
            this.btn_Save.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Save.Location = new System.Drawing.Point(570, 530);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(130, 52);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Gray;
            this.btn_Refresh.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Refresh.Location = new System.Drawing.Point(19, 207);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(225, 52);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_ProductDetails
            // 
            this.btn_ProductDetails.BackColor = System.Drawing.Color.Gray;
            this.btn_ProductDetails.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProductDetails.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_ProductDetails.Location = new System.Drawing.Point(19, 45);
            this.btn_ProductDetails.Name = "btn_ProductDetails";
            this.btn_ProductDetails.Size = new System.Drawing.Size(225, 52);
            this.btn_ProductDetails.TabIndex = 8;
            this.btn_ProductDetails.Text = "Product Details";
            this.btn_ProductDetails.UseVisualStyleBackColor = false;
            this.btn_ProductDetails.Click += new System.EventHandler(this.btn_ProductDetails_Click);
            // 
            // dtp_MfgDate
            // 
            this.dtp_MfgDate.Font = new System.Drawing.Font("Georgia", 13F);
            this.dtp_MfgDate.Location = new System.Drawing.Point(641, 401);
            this.dtp_MfgDate.Name = "dtp_MfgDate";
            this.dtp_MfgDate.Size = new System.Drawing.Size(337, 37);
            this.dtp_MfgDate.TabIndex = 4;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Georgia", 13F);
            this.tb_Name.Location = new System.Drawing.Point(641, 224);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(337, 37);
            this.tb_Name.TabIndex = 1;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Product_Name);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Georgia", 13F);
            this.lbl_Name.Location = new System.Drawing.Point(325, 227);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(82, 30);
            this.lbl_Name.TabIndex = 54;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_ProductNo
            // 
            this.lbl_ProductNo.AutoSize = true;
            this.lbl_ProductNo.Font = new System.Drawing.Font("Georgia", 13F);
            this.lbl_ProductNo.Location = new System.Drawing.Point(325, 168);
            this.lbl_ProductNo.Name = "lbl_ProductNo";
            this.lbl_ProductNo.Size = new System.Drawing.Size(152, 30);
            this.lbl_ProductNo.TabIndex = 46;
            this.lbl_ProductNo.Text = "Product No.";
            // 
            // lbl_User
            // 
            this.lbl_User.AccessibleName = "lbl_Admin";
            this.lbl_User.AutoSize = true;
            this.lbl_User.BackColor = System.Drawing.Color.Tan;
            this.lbl_User.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.Location = new System.Drawing.Point(5, 4);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(20, 24);
            this.lbl_User.TabIndex = 28;
            this.lbl_User.Text = "g";
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Gray;
            this.btn_Logout.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Logout.Location = new System.Drawing.Point(19, 369);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(225, 47);
            this.btn_Logout.TabIndex = 11;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_AddProductDetails
            // 
            this.lbl_AddProductDetails.AutoSize = true;
            this.lbl_AddProductDetails.BackColor = System.Drawing.Color.Linen;
            this.lbl_AddProductDetails.Font = new System.Drawing.Font("Georgia", 38F);
            this.lbl_AddProductDetails.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_AddProductDetails.Location = new System.Drawing.Point(315, 19);
            this.lbl_AddProductDetails.Name = "lbl_AddProductDetails";
            this.lbl_AddProductDetails.Size = new System.Drawing.Size(714, 87);
            this.lbl_AddProductDetails.TabIndex = 22;
            this.lbl_AddProductDetails.Text = "Add Product Details";
            // 
            // lbl_MfgDate
            // 
            this.lbl_MfgDate.AutoSize = true;
            this.lbl_MfgDate.Font = new System.Drawing.Font("Georgia", 13F);
            this.lbl_MfgDate.Location = new System.Drawing.Point(325, 406);
            this.lbl_MfgDate.Name = "lbl_MfgDate";
            this.lbl_MfgDate.Size = new System.Drawing.Size(244, 30);
            this.lbl_MfgDate.TabIndex = 52;
            this.lbl_MfgDate.Text = "Manufacturing Date";
            // 
            // pnl_Header
            // 
            this.pnl_Header.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_Header.BackColor = System.Drawing.Color.Linen;
            this.pnl_Header.Controls.Add(this.pictureBox1);
            this.pnl_Header.Controls.Add(this.lbl_AddProductDetails);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1078, 130);
            this.pnl_Header.TabIndex = 59;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_ExrDate
            // 
            this.lbl_ExrDate.AutoSize = true;
            this.lbl_ExrDate.Font = new System.Drawing.Font("Georgia", 13F);
            this.lbl_ExrDate.Location = new System.Drawing.Point(325, 465);
            this.lbl_ExrDate.Name = "lbl_ExrDate";
            this.lbl_ExrDate.Size = new System.Drawing.Size(150, 30);
            this.lbl_ExrDate.TabIndex = 60;
            this.lbl_ExrDate.Text = "Expiry Date";
            // 
            // dtp_ExpDate
            // 
            this.dtp_ExpDate.Font = new System.Drawing.Font("Georgia", 13F);
            this.dtp_ExpDate.Location = new System.Drawing.Point(641, 460);
            this.dtp_ExpDate.Name = "dtp_ExpDate";
            this.dtp_ExpDate.Size = new System.Drawing.Size(337, 37);
            this.dtp_ExpDate.TabIndex = 5;
            // 
            // lbl_BuyPrice
            // 
            this.lbl_BuyPrice.AutoSize = true;
            this.lbl_BuyPrice.Font = new System.Drawing.Font("Georgia", 13F);
            this.lbl_BuyPrice.Location = new System.Drawing.Point(325, 286);
            this.lbl_BuyPrice.Name = "lbl_BuyPrice";
            this.lbl_BuyPrice.Size = new System.Drawing.Size(160, 30);
            this.lbl_BuyPrice.TabIndex = 62;
            this.lbl_BuyPrice.Text = "Buying Price";
            // 
            // tb_ProductNo
            // 
            this.tb_ProductNo.Enabled = false;
            this.tb_ProductNo.Font = new System.Drawing.Font("Georgia", 13F);
            this.tb_ProductNo.Location = new System.Drawing.Point(641, 165);
            this.tb_ProductNo.MaxLength = 5;
            this.tb_ProductNo.Name = "tb_ProductNo";
            this.tb_ProductNo.Size = new System.Drawing.Size(337, 37);
            this.tb_ProductNo.TabIndex = 58;
            this.tb_ProductNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Product_No);
            // 
            // lbl_SellPrice
            // 
            this.lbl_SellPrice.AutoSize = true;
            this.lbl_SellPrice.Font = new System.Drawing.Font("Georgia", 13F);
            this.lbl_SellPrice.Location = new System.Drawing.Point(325, 345);
            this.lbl_SellPrice.Name = "lbl_SellPrice";
            this.lbl_SellPrice.Size = new System.Drawing.Size(157, 30);
            this.lbl_SellPrice.TabIndex = 64;
            this.lbl_SellPrice.Text = "Selling Price";
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.Linen;
            this.pnl_Menu.Controls.Add(this.lbl_welcome);
            this.pnl_Menu.Controls.Add(this.lbl_User);
            this.pnl_Menu.Controls.Add(this.btn_SearchPatient);
            this.pnl_Menu.Controls.Add(this.btn_Logout);
            this.pnl_Menu.Controls.Add(this.btn_ProductDetails);
            this.pnl_Menu.Controls.Add(this.btn_Refresh);
            this.pnl_Menu.Controls.Add(this.btn_Close);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 130);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(261, 464);
            this.pnl_Menu.TabIndex = 66;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AccessibleName = "";
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.BackColor = System.Drawing.Color.Tan;
            this.lbl_welcome.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(5, 5);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(20, 24);
            this.lbl_welcome.TabIndex = 67;
            this.lbl_welcome.Text = "g";
            // 
            // btn_SearchPatient
            // 
            this.btn_SearchPatient.BackColor = System.Drawing.Color.Gray;
            this.btn_SearchPatient.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchPatient.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_SearchPatient.Location = new System.Drawing.Point(19, 125);
            this.btn_SearchPatient.Name = "btn_SearchPatient";
            this.btn_SearchPatient.Size = new System.Drawing.Size(225, 52);
            this.btn_SearchPatient.TabIndex = 9;
            this.btn_SearchPatient.Text = "Search Product";
            this.btn_SearchPatient.UseVisualStyleBackColor = false;
            this.btn_SearchPatient.Click += new System.EventHandler(this.btn_SearchPatient_Click);
            // 
            // tb_BuyPrice
            // 
            this.tb_BuyPrice.Font = new System.Drawing.Font("Georgia", 13F);
            this.tb_BuyPrice.Location = new System.Drawing.Point(641, 283);
            this.tb_BuyPrice.Name = "tb_BuyPrice";
            this.tb_BuyPrice.Size = new System.Drawing.Size(337, 37);
            this.tb_BuyPrice.TabIndex = 2;
            this.tb_BuyPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buying_Price);
            // 
            // tb_SellPrice
            // 
            this.tb_SellPrice.Font = new System.Drawing.Font("Georgia", 13F);
            this.tb_SellPrice.Location = new System.Drawing.Point(641, 342);
            this.tb_SellPrice.Name = "tb_SellPrice";
            this.tb_SellPrice.Size = new System.Drawing.Size(337, 37);
            this.tb_SellPrice.TabIndex = 3;
            this.tb_SellPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Selling_Price);
            // 
            // frm_AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1078, 594);
            this.ControlBox = false;
            this.Controls.Add(this.tb_SellPrice);
            this.Controls.Add(this.tb_BuyPrice);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.lbl_SellPrice);
            this.Controls.Add(this.lbl_BuyPrice);
            this.Controls.Add(this.dtp_ExpDate);
            this.Controls.Add(this.lbl_ExrDate);
            this.Controls.Add(this.tb_ProductNo);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dtp_MfgDate);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_ProductNo);
            this.Controls.Add(this.lbl_MfgDate);
            this.Controls.Add(this.pnl_Header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.frm_AddProduct_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_ProductDetails;
        private System.Windows.Forms.DateTimePicker dtp_MfgDate;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_ProductNo;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_AddProductDetails;
        private System.Windows.Forms.Label lbl_MfgDate;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_ExrDate;
        private System.Windows.Forms.DateTimePicker dtp_ExpDate;
        private System.Windows.Forms.Label lbl_BuyPrice;
        private System.Windows.Forms.TextBox tb_ProductNo;
        private System.Windows.Forms.Label lbl_SellPrice;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Button btn_SearchPatient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_BuyPrice;
        private System.Windows.Forms.TextBox tb_SellPrice;
        private System.Windows.Forms.Label lbl_welcome;
    }
}