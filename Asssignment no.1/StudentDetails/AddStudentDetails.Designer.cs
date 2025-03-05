
namespace StudentDetails2
{
    partial class frm_AddStudentDetails
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
            this.pnl_AddStudentDetails = new System.Windows.Forms.Panel();
            this.lbl_AddStudentDetails = new System.Windows.Forms.Label();
            this.lbl_Roll_no = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_MobileNo = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_RollNo = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_MobileNo = new System.Windows.Forms.TextBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_StudentList = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.pnl_AddStudentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_AddStudentDetails
            // 
            this.pnl_AddStudentDetails.BackColor = System.Drawing.Color.DarkCyan;
            this.pnl_AddStudentDetails.Controls.Add(this.lbl_AddStudentDetails);
            this.pnl_AddStudentDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_AddStudentDetails.Location = new System.Drawing.Point(0, 0);
            this.pnl_AddStudentDetails.Name = "pnl_AddStudentDetails";
            this.pnl_AddStudentDetails.Size = new System.Drawing.Size(1078, 124);
            this.pnl_AddStudentDetails.TabIndex = 0;
            // 
            // lbl_AddStudentDetails
            // 
            this.lbl_AddStudentDetails.AutoSize = true;
            this.lbl_AddStudentDetails.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddStudentDetails.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_AddStudentDetails.Location = new System.Drawing.Point(211, 22);
            this.lbl_AddStudentDetails.Name = "lbl_AddStudentDetails";
            this.lbl_AddStudentDetails.Size = new System.Drawing.Size(672, 82);
            this.lbl_AddStudentDetails.TabIndex = 2;
            this.lbl_AddStudentDetails.Text = "Add Student Details";
            // 
            // lbl_Roll_no
            // 
            this.lbl_Roll_no.AutoSize = true;
            this.lbl_Roll_no.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roll_no.Location = new System.Drawing.Point(184, 164);
            this.lbl_Roll_no.Name = "lbl_Roll_no";
            this.lbl_Roll_no.Size = new System.Drawing.Size(117, 32);
            this.lbl_Roll_no.TabIndex = 0;
            this.lbl_Roll_no.Text = "Roll No.";
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.Location = new System.Drawing.Point(184, 430);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(102, 32);
            this.lbl_Course.TabIndex = 2;
            this.lbl_Course.Text = "Course";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.Location = new System.Drawing.Point(184, 367);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(75, 32);
            this.lbl_DOB.TabIndex = 3;
            this.lbl_DOB.Text = "DOB";
            // 
            // lbl_MobileNo
            // 
            this.lbl_MobileNo.AutoSize = true;
            this.lbl_MobileNo.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MobileNo.Location = new System.Drawing.Point(184, 296);
            this.lbl_MobileNo.Name = "lbl_MobileNo";
            this.lbl_MobileNo.Size = new System.Drawing.Size(153, 32);
            this.lbl_MobileNo.TabIndex = 4;
            this.lbl_MobileNo.Text = "Mobile No.";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(184, 230);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(89, 32);
            this.lbl_Name.TabIndex = 5;
            this.lbl_Name.Text = "Name";
            // 
            // tb_RollNo
            // 
            this.tb_RollNo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RollNo.Location = new System.Drawing.Point(466, 164);
            this.tb_RollNo.MaxLength = 4;
            this.tb_RollNo.Name = "tb_RollNo";
            this.tb_RollNo.Size = new System.Drawing.Size(338, 35);
            this.tb_RollNo.TabIndex = 1;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(466, 230);
            this.tb_Name.MaxLength = 25;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(338, 35);
            this.tb_Name.TabIndex = 2;
            // 
            // tb_MobileNo
            // 
            this.tb_MobileNo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MobileNo.Location = new System.Drawing.Point(466, 296);
            this.tb_MobileNo.MaxLength = 10;
            this.tb_MobileNo.Name = "tb_MobileNo";
            this.tb_MobileNo.Size = new System.Drawing.Size(338, 35);
            this.tb_MobileNo.TabIndex = 3;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.CalendarFont = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(466, 365);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(338, 35);
            this.dtp_DOB.TabIndex = 4;
            // 
            // cmb_Course
            // 
            this.cmb_Course.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Items.AddRange(new object[] {
            "MCA",
            "BCA",
            "MBA",
            "BBA",
            "BCS"});
            this.cmb_Course.Location = new System.Drawing.Point(466, 430);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(338, 37);
            this.cmb_Course.TabIndex = 5;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.SlateGray;
            this.btn_Submit.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Submit.Location = new System.Drawing.Point(577, 498);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(168, 72);
            this.btn_Submit.TabIndex = 6;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_StudentList
            // 
            this.btn_StudentList.BackColor = System.Drawing.Color.SlateGray;
            this.btn_StudentList.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StudentList.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_StudentList.Location = new System.Drawing.Point(55, 498);
            this.btn_StudentList.Name = "btn_StudentList";
            this.btn_StudentList.Size = new System.Drawing.Size(204, 72);
            this.btn_StudentList.TabIndex = 8;
            this.btn_StudentList.Text = "Student List";
            this.btn_StudentList.UseVisualStyleBackColor = false;
            this.btn_StudentList.Click += new System.EventHandler(this.btn_StudentList_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.SlateGray;
            this.btn_Refresh.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Refresh.Location = new System.Drawing.Point(329, 501);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(168, 72);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.SlateGray;
            this.btn_close.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_close.Location = new System.Drawing.Point(815, 501);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(168, 72);
            this.btn_close.TabIndex = 9;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // frm_AddStudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 585);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_StudentList);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.tb_MobileNo);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_RollNo);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_MobileNo);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_Roll_no);
            this.Controls.Add(this.pnl_AddStudentDetails);
            this.Name = "frm_AddStudentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student Details";
            this.pnl_AddStudentDetails.ResumeLayout(false);
            this.pnl_AddStudentDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_AddStudentDetails;
        private System.Windows.Forms.Label lbl_AddStudentDetails;
        private System.Windows.Forms.Label lbl_Roll_no;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_MobileNo;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_RollNo;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_MobileNo;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_StudentList;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_close;
    }
}