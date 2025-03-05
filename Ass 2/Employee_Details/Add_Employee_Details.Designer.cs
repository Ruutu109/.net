
namespace Employee_Details
{
    partial class frm_AddEmployeeDetails
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
            this.btn_Submit = new System.Windows.Forms.Button();
            this.cb_Department = new System.Windows.Forms.ComboBox();
            this.dtp_DOJ = new System.Windows.Forms.DateTimePicker();
            this.tb_MobileNo = new System.Windows.Forms.TextBox();
            this.tb_EmployeeId = new System.Windows.Forms.TextBox();
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.lbl_DateOfJoining = new System.Windows.Forms.Label();
            this.lbl_MobileNo = new System.Windows.Forms.Label();
            this.lbl_EmployeeId = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_AddEmployeeDetails = new System.Windows.Forms.Panel();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.lbl_AddEmployeeDetails = new System.Windows.Forms.Label();
            this.tb_Salary = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_EmployeeDetails = new System.Windows.Forms.Button();
            this.pnl_AddEmployeeDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.Brown;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Submit.Location = new System.Drawing.Point(634, 515);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(179, 58);
            this.btn_Submit.TabIndex = 7;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // cb_Department
            // 
            this.cb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Department.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Department.FormattingEnabled = true;
            this.cb_Department.Items.AddRange(new object[] {
            "IT",
            "Managment",
            "Finance",
            "Digital Marketing",
            "Security"});
            this.cb_Department.Location = new System.Drawing.Point(574, 437);
            this.cb_Department.Name = "cb_Department";
            this.cb_Department.Size = new System.Drawing.Size(297, 38);
            this.cb_Department.TabIndex = 6;
            // 
            // dtp_DOJ
            // 
            this.dtp_DOJ.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOJ.Location = new System.Drawing.Point(574, 374);
            this.dtp_DOJ.Name = "dtp_DOJ";
            this.dtp_DOJ.Size = new System.Drawing.Size(297, 40);
            this.dtp_DOJ.TabIndex = 5;
            // 
            // tb_MobileNo
            // 
            this.tb_MobileNo.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MobileNo.Location = new System.Drawing.Point(574, 255);
            this.tb_MobileNo.MaxLength = 10;
            this.tb_MobileNo.Name = "tb_MobileNo";
            this.tb_MobileNo.Size = new System.Drawing.Size(297, 40);
            this.tb_MobileNo.TabIndex = 3;
            this.tb_MobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mobile_no);
            // 
            // tb_EmployeeId
            // 
            this.tb_EmployeeId.Enabled = false;
            this.tb_EmployeeId.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_EmployeeId.Location = new System.Drawing.Point(574, 129);
            this.tb_EmployeeId.MaxLength = 5;
            this.tb_EmployeeId.Name = "tb_EmployeeId";
            this.tb_EmployeeId.Size = new System.Drawing.Size(297, 40);
            this.tb_EmployeeId.TabIndex = 1;
            this.tb_EmployeeId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Employee_Id);
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.AutoSize = true;
            this.lbl_Salary.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salary.Location = new System.Drawing.Point(197, 320);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(84, 30);
            this.lbl_Salary.TabIndex = 18;
            this.lbl_Salary.Text = "Salary";
            // 
            // lbl_DateOfJoining
            // 
            this.lbl_DateOfJoining.AutoSize = true;
            this.lbl_DateOfJoining.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateOfJoining.Location = new System.Drawing.Point(197, 381);
            this.lbl_DateOfJoining.Name = "lbl_DateOfJoining";
            this.lbl_DateOfJoining.Size = new System.Drawing.Size(191, 30);
            this.lbl_DateOfJoining.TabIndex = 17;
            this.lbl_DateOfJoining.Text = "Date Of Joining";
            // 
            // lbl_MobileNo
            // 
            this.lbl_MobileNo.AutoSize = true;
            this.lbl_MobileNo.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MobileNo.Location = new System.Drawing.Point(197, 258);
            this.lbl_MobileNo.Name = "lbl_MobileNo";
            this.lbl_MobileNo.Size = new System.Drawing.Size(135, 30);
            this.lbl_MobileNo.TabIndex = 16;
            this.lbl_MobileNo.Text = "Mobile No";
            // 
            // lbl_EmployeeId
            // 
            this.lbl_EmployeeId.AutoSize = true;
            this.lbl_EmployeeId.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmployeeId.Location = new System.Drawing.Point(197, 132);
            this.lbl_EmployeeId.Name = "lbl_EmployeeId";
            this.lbl_EmployeeId.Size = new System.Drawing.Size(156, 30);
            this.lbl_EmployeeId.TabIndex = 15;
            this.lbl_EmployeeId.Text = "Employee Id";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(574, 190);
            this.tb_Name.MaxLength = 30;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(297, 40);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Name);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(197, 193);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(79, 30);
            this.lbl_Name.TabIndex = 13;
            this.lbl_Name.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "Department";
            // 
            // pnl_AddEmployeeDetails
            // 
            this.pnl_AddEmployeeDetails.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnl_AddEmployeeDetails.Controls.Add(this.lbl_welcome);
            this.pnl_AddEmployeeDetails.Controls.Add(this.btn_LogOut);
            this.pnl_AddEmployeeDetails.Controls.Add(this.lbl_AddEmployeeDetails);
            this.pnl_AddEmployeeDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_AddEmployeeDetails.Location = new System.Drawing.Point(0, 0);
            this.pnl_AddEmployeeDetails.Name = "pnl_AddEmployeeDetails";
            this.pnl_AddEmployeeDetails.Size = new System.Drawing.Size(1078, 106);
            this.pnl_AddEmployeeDetails.TabIndex = 25;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.BackColor = System.Drawing.Color.Tan;
            this.lbl_welcome.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(5, 5);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(94, 24);
            this.lbl_welcome.TabIndex = 26;
            this.lbl_welcome.Text = "Welcome";
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.Color.Brown;
            this.btn_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_LogOut.Location = new System.Drawing.Point(960, 8);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(110, 47);
            this.btn_LogOut.TabIndex = 26;
            this.btn_LogOut.Text = "Logout";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // lbl_AddEmployeeDetails
            // 
            this.lbl_AddEmployeeDetails.AutoSize = true;
            this.lbl_AddEmployeeDetails.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_AddEmployeeDetails.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddEmployeeDetails.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_AddEmployeeDetails.Location = new System.Drawing.Point(161, 11);
            this.lbl_AddEmployeeDetails.Name = "lbl_AddEmployeeDetails";
            this.lbl_AddEmployeeDetails.Size = new System.Drawing.Size(738, 82);
            this.lbl_AddEmployeeDetails.TabIndex = 6;
            this.lbl_AddEmployeeDetails.Text = "Add Employee Details";
            // 
            // tb_Salary
            // 
            this.tb_Salary.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Salary.Location = new System.Drawing.Point(574, 317);
            this.tb_Salary.MaxLength = 8;
            this.tb_Salary.Name = "tb_Salary";
            this.tb_Salary.Size = new System.Drawing.Size(297, 40);
            this.tb_Salary.TabIndex = 4;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Brown;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_close.Location = new System.Drawing.Point(857, 515);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(179, 58);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Brown;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Refresh.Location = new System.Drawing.Point(409, 515);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(179, 58);
            this.btn_Refresh.TabIndex = 8;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_EmployeeDetails
            // 
            this.btn_EmployeeDetails.BackColor = System.Drawing.Color.Brown;
            this.btn_EmployeeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EmployeeDetails.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_EmployeeDetails.Location = new System.Drawing.Point(47, 515);
            this.btn_EmployeeDetails.Name = "btn_EmployeeDetails";
            this.btn_EmployeeDetails.Size = new System.Drawing.Size(306, 58);
            this.btn_EmployeeDetails.TabIndex = 8;
            this.btn_EmployeeDetails.Text = "Employee Details";
            this.btn_EmployeeDetails.UseVisualStyleBackColor = false;
            this.btn_EmployeeDetails.Click += new System.EventHandler(this.btn_EmployeeDetails_Click);
            // 
            // frm_AddEmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 585);
            this.ControlBox = false;
            this.Controls.Add(this.btn_EmployeeDetails);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.tb_Salary);
            this.Controls.Add(this.pnl_AddEmployeeDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.cb_Department);
            this.Controls.Add(this.dtp_DOJ);
            this.Controls.Add(this.tb_MobileNo);
            this.Controls.Add(this.tb_EmployeeId);
            this.Controls.Add(this.lbl_Salary);
            this.Controls.Add(this.lbl_DateOfJoining);
            this.Controls.Add(this.lbl_MobileNo);
            this.Controls.Add(this.lbl_EmployeeId);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Name);
            this.Name = "frm_AddEmployeeDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Id";
            this.Load += new System.EventHandler(this.frm_AddEmployeeDetails_Load);
            this.pnl_AddEmployeeDetails.ResumeLayout(false);
            this.pnl_AddEmployeeDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.ComboBox cb_Department;
        private System.Windows.Forms.DateTimePicker dtp_DOJ;
        private System.Windows.Forms.TextBox tb_MobileNo;
        private System.Windows.Forms.TextBox tb_EmployeeId;
        private System.Windows.Forms.Label lbl_Salary;
        private System.Windows.Forms.Label lbl_DateOfJoining;
        private System.Windows.Forms.Label lbl_MobileNo;
        private System.Windows.Forms.Label lbl_EmployeeId;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_AddEmployeeDetails;
        private System.Windows.Forms.Label lbl_AddEmployeeDetails;
        private System.Windows.Forms.TextBox tb_Salary;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_EmployeeDetails;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Label lbl_welcome;
    }
}