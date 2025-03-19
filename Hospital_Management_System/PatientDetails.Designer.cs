
namespace Hospital_Management_System
{
    partial class frm_PatientDetails
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
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.patientDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospital_Management_DBDataSet = new Hospital_Management_System.Hospital_Management_DBDataSet();
            this.patient_DetailsTableAdapter = new Hospital_Management_System.Hospital_Management_DBDataSetTableAdapters.Patient_DetailsTableAdapter();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_AddPatientDetails = new System.Windows.Forms.Button();
            this.btn_SearchPatient = new System.Windows.Forms.Button();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.hospitalManagementDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_PatientDetails = new System.Windows.Forms.DataGridView();
            this.patientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_Management_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PatientDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.DarkCyan;
            this.pnl_Header.Controls.Add(this.btn_Logout);
            this.pnl_Header.Controls.Add(this.lbl_Header);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1078, 123);
            this.pnl_Header.TabIndex = 0;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Brown;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Logout.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Logout.Location = new System.Drawing.Point(960, 9);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(109, 45);
            this.btn_Logout.TabIndex = 5;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Header.Location = new System.Drawing.Point(250, 20);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(504, 82);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Patient Details";
            // 
            // patientDetailsBindingSource
            // 
            this.patientDetailsBindingSource.DataMember = "Patient_Details";
            this.patientDetailsBindingSource.DataSource = this.hospital_Management_DBDataSet;
            // 
            // hospital_Management_DBDataSet
            // 
            this.hospital_Management_DBDataSet.DataSetName = "Hospital_Management_DBDataSet";
            this.hospital_Management_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patient_DetailsTableAdapter
            // 
            this.patient_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Brown;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Close.Location = new System.Drawing.Point(879, 524);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(130, 52);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_AddPatientDetails
            // 
            this.btn_AddPatientDetails.BackColor = System.Drawing.Color.Brown;
            this.btn_AddPatientDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddPatientDetails.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_AddPatientDetails.Location = new System.Drawing.Point(470, 524);
            this.btn_AddPatientDetails.Name = "btn_AddPatientDetails";
            this.btn_AddPatientDetails.Size = new System.Drawing.Size(350, 52);
            this.btn_AddPatientDetails.TabIndex = 2;
            this.btn_AddPatientDetails.Text = "Add Patient Details";
            this.btn_AddPatientDetails.UseVisualStyleBackColor = false;
            this.btn_AddPatientDetails.Click += new System.EventHandler(this.btn_AddPatientDetails_Click);
            // 
            // btn_SearchPatient
            // 
            this.btn_SearchPatient.BackColor = System.Drawing.Color.Brown;
            this.btn_SearchPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchPatient.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_SearchPatient.Location = new System.Drawing.Point(57, 524);
            this.btn_SearchPatient.Name = "btn_SearchPatient";
            this.btn_SearchPatient.Size = new System.Drawing.Size(350, 52);
            this.btn_SearchPatient.TabIndex = 3;
            this.btn_SearchPatient.Text = "Search Patient Details";
            this.btn_SearchPatient.UseVisualStyleBackColor = false;
            this.btn_SearchPatient.Click += new System.EventHandler(this.btn_SearchPatient_Click);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.BackColor = System.Drawing.Color.Tan;
            this.lbl_welcome.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(8, 8);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(94, 24);
            this.lbl_welcome.TabIndex = 29;
            this.lbl_welcome.Text = "Welcome";
            // 
            // hospitalManagementDBDataSetBindingSource
            // 
            this.hospitalManagementDBDataSetBindingSource.DataSource = this.hospital_Management_DBDataSet;
            this.hospitalManagementDBDataSetBindingSource.Position = 0;
            // 
            // dgv_PatientDetails
            // 
            this.dgv_PatientDetails.AutoGenerateColumns = false;
            this.dgv_PatientDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PatientDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PatientDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dgv_PatientDetails.DataSource = this.patientDetailsBindingSource;
            this.dgv_PatientDetails.Location = new System.Drawing.Point(0, 120);
            this.dgv_PatientDetails.Name = "dgv_PatientDetails";
            this.dgv_PatientDetails.RowHeadersWidth = 62;
            this.dgv_PatientDetails.RowTemplate.Height = 28;
            this.dgv_PatientDetails.Size = new System.Drawing.Size(1078, 389);
            this.dgv_PatientDetails.TabIndex = 30;
            // 
            // patientIdDataGridViewTextBoxColumn
            // 
            this.patientIdDataGridViewTextBoxColumn.DataPropertyName = "Patient_Id";
            this.patientIdDataGridViewTextBoxColumn.HeaderText = "Patient_Id";
            this.patientIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.patientIdDataGridViewTextBoxColumn.Name = "patientIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // frm_PatientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1078, 594);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_PatientDetails);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.btn_SearchPatient);
            this.Controls.Add(this.btn_AddPatientDetails);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.pnl_Header);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frm_PatientDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Details";
            this.Load += new System.EventHandler(this.frm_PatientDetails_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospital_Management_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PatientDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Header;
        private Hospital_Management_DBDataSet hospital_Management_DBDataSet;
        private System.Windows.Forms.BindingSource patientDetailsBindingSource;
        private Hospital_Management_DBDataSetTableAdapters.Patient_DetailsTableAdapter patient_DetailsTableAdapter;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_AddPatientDetails;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_SearchPatient;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.BindingSource hospitalManagementDBDataSetBindingSource;
        private System.Windows.Forms.DataGridView dgv_PatientDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}