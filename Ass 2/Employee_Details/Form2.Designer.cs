
namespace Employee_Details
{
    partial class Form2
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
            this.employee_DetailsTableAdapter1 = new Employee_Details.Employee_Details_DBDataSet1TableAdapters.Employee_DetailsTableAdapter();
            this.btn_AddEmployeeDetails = new System.Windows.Forms.Button();
            this.lbl_EmployeeDetails = new System.Windows.Forms.Label();
            this.pnl_Login = new System.Windows.Forms.Panel();
            this.employeeDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admission_System_App_DBDataSet = new Employee_Details.Admission_System_App_DBDataSet();
            this.employee_DetailsTableAdapter = new Employee_Details.Admission_System_App_DBDataSetTableAdapters.Employee_DetailsTableAdapter();
            this.btn_close = new System.Windows.Forms.Button();
            this.employee_Details_DBDataSet1 = new Employee_Details.Employee_Details_DBDataSet1();
            this.dgv_EmployeeDetails = new System.Windows.Forms.DataGridView();
            this.employee_Details_DBDataSet2 = new Employee_Details.Employee_Details_DBDataSet2();
            this.employeeDetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.employee_DetailsTableAdapter2 = new Employee_Details.Employee_Details_DBDataSet2TableAdapters.Employee_DetailsTableAdapter();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admission_System_App_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Details_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EmployeeDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Details_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // employee_DetailsTableAdapter1
            // 
            this.employee_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // btn_AddEmployeeDetails
            // 
            this.btn_AddEmployeeDetails.BackColor = System.Drawing.Color.Brown;
            this.btn_AddEmployeeDetails.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddEmployeeDetails.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_AddEmployeeDetails.Location = new System.Drawing.Point(135, 512);
            this.btn_AddEmployeeDetails.Name = "btn_AddEmployeeDetails";
            this.btn_AddEmployeeDetails.Size = new System.Drawing.Size(469, 64);
            this.btn_AddEmployeeDetails.TabIndex = 20;
            this.btn_AddEmployeeDetails.Text = "Add Employee Details";
            this.btn_AddEmployeeDetails.UseVisualStyleBackColor = false;
            // 
            // lbl_EmployeeDetails
            // 
            this.lbl_EmployeeDetails.AutoSize = true;
            this.lbl_EmployeeDetails.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_EmployeeDetails.Font = new System.Drawing.Font("Georgia", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmployeeDetails.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_EmployeeDetails.Location = new System.Drawing.Point(301, 9);
            this.lbl_EmployeeDetails.Name = "lbl_EmployeeDetails";
            this.lbl_EmployeeDetails.Size = new System.Drawing.Size(493, 69);
            this.lbl_EmployeeDetails.TabIndex = 6;
            this.lbl_EmployeeDetails.Text = "Employee Details";
            // 
            // pnl_Login
            // 
            this.pnl_Login.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnl_Login.Controls.Add(this.lbl_EmployeeDetails);
            this.pnl_Login.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Login.Location = new System.Drawing.Point(0, 0);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(1078, 95);
            this.pnl_Login.TabIndex = 22;
            // 
            // employeeDetailsBindingSource1
            // 
            this.employeeDetailsBindingSource1.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource1.DataSource = this.employee_Details_DBDataSet1;
            // 
            // employeeDetailsBindingSource
            // 
            this.employeeDetailsBindingSource.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource.DataSource = this.admission_System_App_DBDataSet;
            // 
            // admission_System_App_DBDataSet
            // 
            this.admission_System_App_DBDataSet.DataSetName = "Admission_System_App_DBDataSet";
            this.admission_System_App_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employee_DetailsTableAdapter
            // 
            this.employee_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Brown;
            this.btn_close.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_close.Location = new System.Drawing.Point(750, 514);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(179, 58);
            this.btn_close.TabIndex = 21;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // employee_Details_DBDataSet1
            // 
            this.employee_Details_DBDataSet1.DataSetName = "Employee_Details_DBDataSet1";
            this.employee_Details_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgv_EmployeeDetails
            // 
            this.dgv_EmployeeDetails.AutoGenerateColumns = false;
            this.dgv_EmployeeDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_EmployeeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_EmployeeDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.dOJDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn});
            this.dgv_EmployeeDetails.DataSource = this.employeeDetailsBindingSource2;
            this.dgv_EmployeeDetails.Location = new System.Drawing.Point(0, 90);
            this.dgv_EmployeeDetails.Name = "dgv_EmployeeDetails";
            this.dgv_EmployeeDetails.RowHeadersWidth = 62;
            this.dgv_EmployeeDetails.RowTemplate.Height = 28;
            this.dgv_EmployeeDetails.Size = new System.Drawing.Size(1078, 409);
            this.dgv_EmployeeDetails.TabIndex = 23;
            // 
            // employee_Details_DBDataSet2
            // 
            this.employee_Details_DBDataSet2.DataSetName = "Employee_Details_DBDataSet2";
            this.employee_Details_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeDetailsBindingSource2
            // 
            this.employeeDetailsBindingSource2.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource2.DataSource = this.employee_Details_DBDataSet2;
            // 
            // employee_DetailsTableAdapter2
            // 
            this.employee_DetailsTableAdapter2.ClearBeforeFill = true;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "Employee_Id";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "Employee_Id";
            this.employeeIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // dOJDataGridViewTextBoxColumn
            // 
            this.dOJDataGridViewTextBoxColumn.DataPropertyName = "DOJ";
            this.dOJDataGridViewTextBoxColumn.HeaderText = "DOJ";
            this.dOJDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dOJDataGridViewTextBoxColumn.Name = "dOJDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 585);
            this.Controls.Add(this.dgv_EmployeeDetails);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.pnl_Login);
            this.Controls.Add(this.btn_AddEmployeeDetails);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnl_Login.ResumeLayout(false);
            this.pnl_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admission_System_App_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Details_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EmployeeDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Details_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Employee_Details_DBDataSet1TableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter1;
        private System.Windows.Forms.Button btn_AddEmployeeDetails;
        private System.Windows.Forms.Label lbl_EmployeeDetails;
        private System.Windows.Forms.Panel pnl_Login;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource1;
        private Employee_Details_DBDataSet1 employee_Details_DBDataSet1;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource;
        private Admission_System_App_DBDataSet admission_System_App_DBDataSet;
        private Admission_System_App_DBDataSetTableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DataGridView dgv_EmployeeDetails;
        private Employee_Details_DBDataSet2 employee_Details_DBDataSet2;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource2;
        private Employee_Details_DBDataSet2TableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
    }
}