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
    public partial class frm_PatientDetails : Form
    {
        public frm_PatientDetails()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ruutu;Initial Catalog=Hospital_Management_DB;Integrated Security=True");

        void Rcon_Open()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }

        void Rcon_Close()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }
        private void frm_PatientDetails_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text = Shared_Content.UName;

            Rcon_Open();

            dgv_PatientDetails.DataSource = "";

            SqlDataAdapter sda = new SqlDataAdapter("Select * from Patient_Details", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgv_PatientDetails.DataSource = dt;

            Rcon_Close();
        }

        private void btn_SearchPatient_Click(object sender, EventArgs e)
        {
            frm_SearchPatientDetails spd = new frm_SearchPatientDetails();
            spd.Show();
            this.Hide();
        }

        private void btn_AddPatientDetails_Click(object sender, EventArgs e)
        {
            frm_AddPatientDetails apd = new frm_AddPatientDetails();
            apd.Show();
            this.Hide();
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

    }
}
