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
    public partial class frm_AddPatientDetails : Form
    {
        public frm_AddPatientDetails()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ruutu;Initial Catalog=Hospital_Management_DB;Integrated Security=True");

        void con_Open()
        {
            if(con.State != ConnectionState.Open)
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
        private void Patient_Id(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || (e.KeyChar==(char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Patient_Name(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar)||(e.KeyChar==(char)Keys.Back)||(e.KeyChar==(char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void Mobile_No(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar)||(e.KeyChar==(char)Keys.Back)))
            {
                e.Handled = true;
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

        int Auto_Incr()
        {
            int cnt = 0;

            con_Open();

            SqlCommand cmd = new SqlCommand("Select Count(Patient_Id) from Patient_Details", con);

            cnt = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.Dispose();

            if (cnt > 0)
            {
                cmd.Connection = con;
                cmd.CommandText = "Select Max(Patient_Id) from Patient_Details";

                cnt = Convert.ToInt32(cmd.ExecuteScalar());
            }
            else
            {
                cnt = 0;
            }

            con_Close();

            return (cnt+1);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            con_Open();

            if (tb_PatientId.Text != "" && tb_Name.Text != "" && tb_MobileNo.Text != "" && tb_Address.Text != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Insert Into Patient_Details Values(@PId,@Nm,@DOB,@MNo,@Add)";
                cmd.Parameters.Add("PId", SqlDbType.Int).Value = tb_PatientId.Text;
                cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Text;
                cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_MobileNo.Text;
                cmd.Parameters.Add("Add", SqlDbType.NVarChar).Value = tb_Address.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Insert Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Incomplete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con_Close();
            clear_Details();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            clear_Details();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are you sure do you want to close this Application?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_PatientDetails_Click(object sender, EventArgs e)
        {
            frm_PatientDetails pd = new frm_PatientDetails();
            pd.Show();
            this.Hide();
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

        private void frm_AddPatientDetails_Load_1(object sender, EventArgs e)
        {
            lbl_welcome.Text = Shared_Content.UName;
            tb_PatientId.Text = Convert.ToString(Auto_Incr());
        }
    }
}
