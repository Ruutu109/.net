
namespace StudentDetails2
{
    partial class frm_StudentDetails
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
            this.pnl_AddStudentDetails = new System.Windows.Forms.Panel();
            this.lbl_StudentDetails = new System.Windows.Forms.Label();
            this.dgv_StudentDetails = new System.Windows.Forms.DataGridView();
            this.rollnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admission_System_App_DBDataSet = new StudentDetails2.Admission_System_App_DBDataSet();
            this.student_DetailsTableAdapter = new StudentDetails2.Admission_System_App_DBDataSetTableAdapters.Student_DetailsTableAdapter();
            this.btn_AddnewStudent = new System.Windows.Forms.Button();
            this.pnl_AddStudentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admission_System_App_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_AddStudentDetails
            // 
            this.pnl_AddStudentDetails.BackColor = System.Drawing.Color.DarkCyan;
            this.pnl_AddStudentDetails.Controls.Add(this.lbl_StudentDetails);
            this.pnl_AddStudentDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_AddStudentDetails.Location = new System.Drawing.Point(0, 0);
            this.pnl_AddStudentDetails.Name = "pnl_AddStudentDetails";
            this.pnl_AddStudentDetails.Size = new System.Drawing.Size(1078, 124);
            this.pnl_AddStudentDetails.TabIndex = 1;
            // 
            // lbl_StudentDetails
            // 
            this.lbl_StudentDetails.AutoSize = true;
            this.lbl_StudentDetails.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StudentDetails.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_StudentDetails.Location = new System.Drawing.Point(248, 20);
            this.lbl_StudentDetails.Name = "lbl_StudentDetails";
            this.lbl_StudentDetails.Size = new System.Drawing.Size(525, 82);
            this.lbl_StudentDetails.TabIndex = 2;
            this.lbl_StudentDetails.Text = "Student Details";
            // 
            // dgv_StudentDetails
            // 
            this.dgv_StudentDetails.AllowUserToAddRows = false;
            this.dgv_StudentDetails.AllowUserToDeleteRows = false;
            this.dgv_StudentDetails.AutoGenerateColumns = false;
            this.dgv_StudentDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_StudentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StudentDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollnoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobilenoDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_StudentDetails.DataSource = this.studentDetailsBindingSource;
            this.dgv_StudentDetails.Location = new System.Drawing.Point(40, 145);
            this.dgv_StudentDetails.Name = "dgv_StudentDetails";
            this.dgv_StudentDetails.ReadOnly = true;
            this.dgv_StudentDetails.RowHeadersWidth = 62;
            this.dgv_StudentDetails.RowTemplate.Height = 28;
            this.dgv_StudentDetails.Size = new System.Drawing.Size(1003, 337);
            this.dgv_StudentDetails.TabIndex = 2;
            // 
            // rollnoDataGridViewTextBoxColumn
            // 
            this.rollnoDataGridViewTextBoxColumn.DataPropertyName = "Roll_no";
            this.rollnoDataGridViewTextBoxColumn.HeaderText = "Roll_no";
            this.rollnoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rollnoDataGridViewTextBoxColumn.Name = "rollnoDataGridViewTextBoxColumn";
            this.rollnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobilenoDataGridViewTextBoxColumn
            // 
            this.mobilenoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_no";
            this.mobilenoDataGridViewTextBoxColumn.HeaderText = "Mobile_no";
            this.mobilenoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mobilenoDataGridViewTextBoxColumn.Name = "mobilenoDataGridViewTextBoxColumn";
            this.mobilenoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student_Details";
            this.studentDetailsBindingSource.DataSource = this.admission_System_App_DBDataSet;
            // 
            // admission_System_App_DBDataSet
            // 
            this.admission_System_App_DBDataSet.DataSetName = "Admission_System_App_DBDataSet";
            this.admission_System_App_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_AddnewStudent
            // 
            this.btn_AddnewStudent.BackColor = System.Drawing.Color.SlateGray;
            this.btn_AddnewStudent.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddnewStudent.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_AddnewStudent.Location = new System.Drawing.Point(401, 501);
            this.btn_AddnewStudent.Name = "btn_AddnewStudent";
            this.btn_AddnewStudent.Size = new System.Drawing.Size(279, 72);
            this.btn_AddnewStudent.TabIndex = 9;
            this.btn_AddnewStudent.Text = "Add New Student";
            this.btn_AddnewStudent.UseVisualStyleBackColor = false;
            this.btn_AddnewStudent.Click += new System.EventHandler(this.btn_StudentList_Click);
            // 
            // frm_StudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 585);
            this.ControlBox = false;
            this.Controls.Add(this.btn_AddnewStudent);
            this.Controls.Add(this.dgv_StudentDetails);
            this.Controls.Add(this.pnl_AddStudentDetails);
            this.Name = "frm_StudentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.frm_StudentDetails_Load);
            this.pnl_AddStudentDetails.ResumeLayout(false);
            this.pnl_AddStudentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admission_System_App_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_AddStudentDetails;
        private System.Windows.Forms.Label lbl_StudentDetails;
        private System.Windows.Forms.DataGridView dgv_StudentDetails;
        private Admission_System_App_DBDataSet admission_System_App_DBDataSet;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private Admission_System_App_DBDataSetTableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_AddnewStudent;
    }
}