using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class frm_SearchPatientDetails : Form
    {
        public frm_SearchPatientDetails()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ruutu;Initial Catalog=Hospital_Management_DB;Integrated Security=True");

        void con_Open()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }
        void con_Close()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }

        void clear_Details()
        {
            tb_Name.Text = "";
            tb_MobileNo.Text = "";
            dtp_DOB.ResetText();
            tb_Address.Text = "";

            tb_Name.Focus();
        }

        private void btn_PatientDetails_Click(object sender, EventArgs e)
        {
            frm_PatientDetails pd = new frm_PatientDetails();
            pd.Show();
            this.Hide();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_PatientId.Clear();
            clear_Details();
        }

        private void btn_AddPatient_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are you sure do you want to Go Back?", "Add Patient", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Res == DialogResult.Yes)
            {
                frm_AddPatientDetails lf = new frm_AddPatientDetails();
                lf.Show();
                this.Hide();
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are you sure do you want to close this Application?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are you sure do you want to Logout?", "Logging Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Res == DialogResult.Yes)
            {
                frm_LoginForm lf = new frm_LoginForm();
                lf.Show();
                this.Hide();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            con_Open();

            SqlCommand cmd = new SqlCommand("Select * From Patient_Details where Patient_Id = @PNo",con);

            cmd.Parameters.Add("PNo", SqlDbType.Int).Value = tb_PatientId.Text;

            SqlDataReader Dr = cmd.ExecuteReader();

            if(Dr.Read())
            {
                tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                dtp_DOB.Text = (Dr["DOB"].ToString());
                tb_MobileNo.Text = (Dr["Mobile_No"].ToString());
                tb_Address.Text = Dr.GetString(Dr.GetOrdinal("Address"));
            }
            else
            {
                MessageBox.Show("Invalid Roll No.", "NO PATIENT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_PatientId.Clear();
            }

            con_Close();
        }

        private void frm_SearchPatientDetails_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text = Shared_Content.UName;
        }

        
    }
}
