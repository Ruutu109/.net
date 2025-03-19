
namespace Hospital_Management_System
{
    partial class frm_SearchPatientDetails
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
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_PatientDetails = new System.Windows.Forms.Button();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_MobileNo = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_DateOfBirth = new System.Windows.Forms.Label();
            this.lbl_MobileNo = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_PatientNo = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.tb_PatientId = new System.Windows.Forms.TextBox();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.btn_AddPatient = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Brown;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Logout.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Logout.Location = new System.Drawing.Point(957, 8);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(112, 45);
            this.btn_Logout.TabIndex = 15;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Brown;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Close.Location = new System.Drawing.Point(862, 528);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(130, 52);
            this.btn_Close.TabIndex = 29;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Brown;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Refresh.Location = new System.Drawing.Point(631, 528);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(158, 52);
            this.btn_Refresh.TabIndex = 27;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_PatientDetails
            // 
            this.btn_PatientDetails.BackColor = System.Drawing.Color.Brown;
            this.btn_PatientDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PatientDetails.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_PatientDetails.Location = new System.Drawing.Point(311, 528);
            this.btn_PatientDetails.Name = "btn_PatientDetails";
            this.btn_PatientDetails.Size = new System.Drawing.Size(253, 52);
            this.btn_PatientDetails.TabIndex = 26;
            this.btn_PatientDetails.Text = "Patient Details";
            this.btn_PatientDetails.UseVisualStyleBackColor = false;
            this.btn_PatientDetails.Click += new System.EventHandler(this.btn_PatientDetails_Click);
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Enabled = false;
            this.dtp_DOB.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(489, 311);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(337, 39);
            this.dtp_DOB.TabIndex = 25;
            // 
            // tb_Address
            // 
            this.tb_Address.Enabled = false;
            this.tb_Address.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(489, 454);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(337, 39);
            this.tb_Address.TabIndex = 24;
            // 
            // tb_MobileNo
            // 
            this.tb_MobileNo.Enabled = false;
            this.tb_MobileNo.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MobileNo.Location = new System.Drawing.Point(489, 385);
            this.tb_MobileNo.Name = "tb_MobileNo";
            this.tb_MobileNo.Size = new System.Drawing.Size(337, 39);
            this.tb_MobileNo.TabIndex = 23;
            // 
            // tb_Name
            // 
            this.tb_Name.Enabled = false;
            this.tb_Name.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(489, 245);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(337, 39);
            this.tb_Name.TabIndex = 22;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Georgia", 14F);
            this.lbl_Name.Location = new System.Drawing.Point(209, 248);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(89, 32);
            this.lbl_Name.TabIndex = 20;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_DateOfBirth
            // 
            this.lbl_DateOfBirth.AutoSize = true;
            this.lbl_DateOfBirth.Font = new System.Drawing.Font("Georgia", 14F);
            this.lbl_DateOfBirth.Location = new System.Drawing.Point(209, 316);
            this.lbl_DateOfBirth.Name = "lbl_DateOfBirth";
            this.lbl_DateOfBirth.Size = new System.Drawing.Size(182, 32);
            this.lbl_DateOfBirth.TabIndex = 19;
            this.lbl_DateOfBirth.Text = "Date Of Birth";
            // 
            // lbl_MobileNo
            // 
            this.lbl_MobileNo.AutoSize = true;
            this.lbl_MobileNo.Font = new System.Drawing.Font("Georgia", 14F);
            this.lbl_MobileNo.Location = new System.Drawing.Point(209, 388);
            this.lbl_MobileNo.Name = "lbl_MobileNo";
            this.lbl_MobileNo.Size = new System.Drawing.Size(153, 32);
            this.lbl_MobileNo.TabIndex = 18;
            this.lbl_MobileNo.Text = "Mobile No.";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Georgia", 14F);
            this.lbl_Address.Location = new System.Drawing.Point(209, 457);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(115, 32);
            this.lbl_Address.TabIndex = 17;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_PatientNo
            // 
            this.lbl_PatientNo.AutoSize = true;
            this.lbl_PatientNo.Font = new System.Drawing.Font("Georgia", 14F);
            this.lbl_PatientNo.Location = new System.Drawing.Point(209, 180);
            this.lbl_PatientNo.Name = "lbl_PatientNo";
            this.lbl_PatientNo.Size = new System.Drawing.Size(156, 32);
            this.lbl_PatientNo.TabIndex = 16;
            this.lbl_PatientNo.Text = "Patient No.";
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Georgia", 38F);
            this.lbl_Header.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Header.Location = new System.Drawing.Point(154, 21);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(776, 87);
            this.lbl_Header.TabIndex = 111;
            this.lbl_Header.Text = "Search Patient Details";
            // 
            // tb_PatientId
            // 
            this.tb_PatientId.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PatientId.Location = new System.Drawing.Point(489, 177);
            this.tb_PatientId.Name = "tb_PatientId";
            this.tb_PatientId.Size = new System.Drawing.Size(337, 39);
            this.tb_PatientId.TabIndex = 1;
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.DarkCyan;
            this.pnl_Header.Controls.Add(this.btn_Logout);
            this.pnl_Header.Controls.Add(this.lbl_Header);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1078, 130);
            this.pnl_Header.TabIndex = 15;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Search.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_Search.Location = new System.Drawing.Point(862, 177);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(151, 39);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.BackColor = System.Drawing.Color.Tan;
            this.lbl_welcome.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(9, 9);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(94, 24);
            this.lbl_welcome.TabIndex = 31;
            this.lbl_welcome.Text = "Welcome";
            // 
            // btn_AddPatient
            // 
            this.btn_AddPatient.BackColor = System.Drawing.Color.Brown;
            this.btn_AddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddPatient.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_AddPatient.Location = new System.Drawing.Point(23, 528);
            this.btn_AddPatient.Name = "btn_AddPatient";
            this.btn_AddPatient.Size = new System.Drawing.Size(216, 52);
            this.btn_AddPatient.TabIndex = 28;
            this.btn_AddPatient.Text = "Add Patient";
            this.btn_AddPatient.UseVisualStyleBackColor = false;
            this.btn_AddPatient.Click += new System.EventHandler(this.btn_AddPatient_Click);
            // 
            // frm_SearchPatientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1078, 594);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_AddPatient);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_PatientDetails);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.tb_MobileNo);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_DateOfBirth);
            this.Controls.Add(this.lbl_MobileNo);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_PatientNo);
            this.Controls.Add(this.tb_PatientId);
            this.Controls.Add(this.pnl_Header);
            this.Name = "frm_SearchPatientDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Patient Details";
            this.Load += new System.EventHandler(this.frm_SearchPatientDetails_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_PatientDetails;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox tb_MobileNo;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_DateOfBirth;
        private System.Windows.Forms.Label lbl_MobileNo;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_PatientNo;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.TextBox tb_PatientId;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button btn_AddPatient;
    }
}