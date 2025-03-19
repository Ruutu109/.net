
namespace Hospital_Management_System
{
    partial class frm_AddPatientDetails
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
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_PatientNo = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_MobileNo = new System.Windows.Forms.Label();
            this.lbl_DateOfBirth = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_MobileNo = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.btn_PatientDetails = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.tb_PatientId = new System.Windows.Forms.TextBox();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.DarkCyan;
            this.pnl_Header.Controls.Add(this.lbl_welcome);
            this.pnl_Header.Controls.Add(this.btn_Logout);
            this.pnl_Header.Controls.Add(this.lbl_Header);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1078, 130);
            this.pnl_Header.TabIndex = 44;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.BackColor = System.Drawing.Color.Tan;
            this.lbl_welcome.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(8, 8);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(94, 24);
            this.lbl_welcome.TabIndex = 28;
            this.lbl_welcome.Text = "Welcome";
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Brown;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Logout.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Logout.Location = new System.Drawing.Point(960, 8);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(110, 47);
            this.btn_Logout.TabIndex = 5367;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Georgia", 38F);
            this.lbl_Header.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Header.Location = new System.Drawing.Point(188, 25);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(687, 87);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Add Patient Details";
            // 
            // lbl_PatientNo
            // 
            this.lbl_PatientNo.AutoSize = true;
            this.lbl_PatientNo.Font = new System.Drawing.Font("Georgia", 14F);
            this.lbl_PatientNo.Location = new System.Drawing.Point(209, 177);
            this.lbl_PatientNo.Name = "lbl_PatientNo";
            this.lbl_PatientNo.Size = new System.Drawing.Size(156, 32);
            this.lbl_PatientNo.TabIndex = 1;
            this.lbl_PatientNo.Text = "Patient No.";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Georgia", 14F);
            this.lbl_Address.Location = new System.Drawing.Point(209, 448);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(115, 32);
            this.lbl_Address.TabIndex = 2;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_MobileNo
            // 
            this.lbl_MobileNo.AutoSize = true;
            this.lbl_MobileNo.Font = new System.Drawing.Font("Georgia", 14F);
            this.lbl_MobileNo.Location = new System.Drawing.Point(209, 380);
            this.lbl_MobileNo.Name = "lbl_MobileNo";
            this.lbl_MobileNo.Size = new System.Drawing.Size(153, 32);
            this.lbl_MobileNo.TabIndex = 3;
            this.lbl_MobileNo.Text = "Mobile No.";
            // 
            // lbl_DateOfBirth
            // 
            this.lbl_DateOfBirth.AutoSize = true;
            this.lbl_DateOfBirth.Font = new System.Drawing.Font("Georgia", 14F);
            this.lbl_DateOfBirth.Location = new System.Drawing.Point(209, 311);
            this.lbl_DateOfBirth.Name = "lbl_DateOfBirth";
            this.lbl_DateOfBirth.Size = new System.Drawing.Size(182, 32);
            this.lbl_DateOfBirth.TabIndex = 4;
            this.lbl_DateOfBirth.Text = "Date Of Birth";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Georgia", 14F);
            this.lbl_Name.Location = new System.Drawing.Point(209, 243);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(89, 32);
            this.lbl_Name.TabIndex = 5;
            this.lbl_Name.Text = "Name";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(489, 240);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(337, 39);
            this.tb_Name.TabIndex = 1;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Patient_Name);
            // 
            // tb_MobileNo
            // 
            this.tb_MobileNo.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MobileNo.Location = new System.Drawing.Point(489, 377);
            this.tb_MobileNo.Name = "tb_MobileNo";
            this.tb_MobileNo.Size = new System.Drawing.Size(337, 39);
            this.tb_MobileNo.TabIndex = 3;
            this.tb_MobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mobile_No);
            // 
            // tb_Address
            // 
            this.tb_Address.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(489, 445);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(337, 39);
            this.tb_Address.TabIndex = 4;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(489, 316);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(337, 39);
            this.dtp_DOB.TabIndex = 2;
            // 
            // btn_PatientDetails
            // 
            this.btn_PatientDetails.BackColor = System.Drawing.Color.Brown;
            this.btn_PatientDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PatientDetails.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_PatientDetails.Location = new System.Drawing.Point(84, 522);
            this.btn_PatientDetails.Name = "btn_PatientDetails";
            this.btn_PatientDetails.Size = new System.Drawing.Size(253, 52);
            this.btn_PatientDetails.TabIndex = 6;
            this.btn_PatientDetails.Text = "Patient Details";
            this.btn_PatientDetails.UseVisualStyleBackColor = false;
            this.btn_PatientDetails.Click += new System.EventHandler(this.btn_PatientDetails_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Brown;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Refresh.Location = new System.Drawing.Point(421, 522);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(149, 52);
            this.btn_Refresh.TabIndex = 8;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Brown;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Save.Location = new System.Drawing.Point(645, 522);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(130, 52);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Brown;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Close.Location = new System.Drawing.Point(860, 522);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(130, 52);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // tb_PatientId
            // 
            this.tb_PatientId.Enabled = false;
            this.tb_PatientId.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PatientId.Location = new System.Drawing.Point(489, 176);
            this.tb_PatientId.MaxLength = 5;
            this.tb_PatientId.Name = "tb_PatientId";
            this.tb_PatientId.Size = new System.Drawing.Size(337, 39);
            this.tb_PatientId.TabIndex = 15;
            this.tb_PatientId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Patient_Id);
            // 
            // frm_AddPatientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1078, 594);
            this.ControlBox = false;
            this.Controls.Add(this.tb_PatientId);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Save);
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
            this.Controls.Add(this.pnl_Header);
            this.Name = "frm_AddPatientDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Patient Details";
            this.Load += new System.EventHandler(this.frm_AddPatientDetails_Load_1);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_PatientNo;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_MobileNo;
        private System.Windows.Forms.Label lbl_DateOfBirth;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_MobileNo;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.Button btn_PatientDetails;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.TextBox tb_PatientId;
    }
}