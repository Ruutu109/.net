
namespace Student_Details
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
            this.lbl_AddStudentDetails = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_RollNo = new System.Windows.Forms.Label();
            this.lbl_MobileNo = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.tb_RollNo = new System.Windows.Forms.TextBox();
            this.tb_MobileNo = new System.Windows.Forms.TextBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.cb_Course = new System.Windows.Forms.ComboBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_AddStudentDetails
            // 
            this.lbl_AddStudentDetails.AutoSize = true;
            this.lbl_AddStudentDetails.BackColor = System.Drawing.Color.Cornsilk;
            this.lbl_AddStudentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddStudentDetails.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_AddStudentDetails.Location = new System.Drawing.Point(292, 48);
            this.lbl_AddStudentDetails.Name = "lbl_AddStudentDetails";
            this.lbl_AddStudentDetails.Size = new System.Drawing.Size(522, 64);
            this.lbl_AddStudentDetails.TabIndex = 0;
            this.lbl_AddStudentDetails.Text = "Add Student Details";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(229, 161);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(91, 34);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.Click += new System.EventHandler(this.lbl_Name_Click);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(621, 161);
            this.tb_Name.MaxLength = 30;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(297, 40);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.TextChanged += new System.EventHandler(this.tb_Name_TextChanged);
            // 
            // lbl_RollNo
            // 
            this.lbl_RollNo.AutoSize = true;
            this.lbl_RollNo.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RollNo.Location = new System.Drawing.Point(229, 247);
            this.lbl_RollNo.Name = "lbl_RollNo";
            this.lbl_RollNo.Size = new System.Drawing.Size(117, 34);
            this.lbl_RollNo.TabIndex = 3;
            this.lbl_RollNo.Text = "Roll No";
            // 
            // lbl_MobileNo
            // 
            this.lbl_MobileNo.AutoSize = true;
            this.lbl_MobileNo.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MobileNo.Location = new System.Drawing.Point(229, 324);
            this.lbl_MobileNo.Name = "lbl_MobileNo";
            this.lbl_MobileNo.Size = new System.Drawing.Size(154, 34);
            this.lbl_MobileNo.TabIndex = 4;
            this.lbl_MobileNo.Text = "Mobile No";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.Location = new System.Drawing.Point(229, 397);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(82, 34);
            this.lbl_DOB.TabIndex = 5;
            this.lbl_DOB.Text = "DOB";
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.Location = new System.Drawing.Point(229, 467);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(105, 34);
            this.lbl_Course.TabIndex = 6;
            this.lbl_Course.Text = "Course";
            // 
            // tb_RollNo
            // 
            this.tb_RollNo.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RollNo.Location = new System.Drawing.Point(621, 241);
            this.tb_RollNo.MaxLength = 12;
            this.tb_RollNo.Name = "tb_RollNo";
            this.tb_RollNo.Size = new System.Drawing.Size(297, 40);
            this.tb_RollNo.TabIndex = 7;
            this.tb_RollNo.TextChanged += new System.EventHandler(this.tb_RollNo_TextChanged);
            // 
            // tb_MobileNo
            // 
            this.tb_MobileNo.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MobileNo.Location = new System.Drawing.Point(621, 318);
            this.tb_MobileNo.MaxLength = 10;
            this.tb_MobileNo.Name = "tb_MobileNo";
            this.tb_MobileNo.Size = new System.Drawing.Size(297, 40);
            this.tb_MobileNo.TabIndex = 8;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(621, 400);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(297, 31);
            this.dtp_DOB.TabIndex = 9;
            // 
            // cb_Course
            // 
            this.cb_Course.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Course.FormattingEnabled = true;
            this.cb_Course.Location = new System.Drawing.Point(621, 463);
            this.cb_Course.Name = "cb_Course";
            this.cb_Course.Size = new System.Drawing.Size(297, 38);
            this.cb_Course.TabIndex = 10;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Submit.Location = new System.Drawing.Point(447, 555);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(177, 51);
            this.btn_Submit.TabIndex = 11;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // frm_AddStudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 644);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.cb_Course);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.tb_MobileNo);
            this.Controls.Add(this.tb_RollNo);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_MobileNo);
            this.Controls.Add(this.lbl_RollNo);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_AddStudentDetails);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AddStudentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AddStudentDetails;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_RollNo;
        private System.Windows.Forms.Label lbl_MobileNo;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.TextBox tb_RollNo;
        private System.Windows.Forms.TextBox tb_MobileNo;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.ComboBox cb_Course;
        private System.Windows.Forms.Button btn_Submit;
    }
}