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
    public partial class frm_LoginForm : Form
    {
        public frm_LoginForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ruutu;Initial Catalog=Hospital_Management_DB;Integrated Security=True");
        void con_open()
        {
            if(con.State!=ConnectionState.Open)
            {
                con.Open();
            }
        }
        void con_close()
        {
            if(con.State!=ConnectionState.Closed)
            {
                con.Close();
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            con_open();

            SqlCommand cmd = new SqlCommand("Select Count(*) From Login_Details Where Username = @Unm And Password = @Pwd",con);

            cmd.Parameters.Add("Unm",SqlDbType.NVarChar).Value = tb_Username.Text;
            cmd.Parameters.Add("Pwd",SqlDbType.NVarChar).Value = tb_Password.Text;
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            if(cnt>0)
            {
                MessageBox.Show("Login Successfully", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Shared_Content.UName = "Welcome " + tb_Username.Text;

                frm_AddPatientDetails apd = new frm_AddPatientDetails();
                apd.Show();
                this.Hide();
            }
            else
            {
                lbl_Note.Text = "Invalid Credentials, Enter Correct Details!!";
                lbl_Note.BackColor = Color.DarkOrchid;
                lbl_Note.ForeColor = Color.Cornsilk;
            }

            tb_Username.Clear();
            tb_Password.Clear();

            tb_Password.Enabled = false;
            btn_Login.Enabled = false;

            tb_Username.Focus();
            con_close();
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure Do You Want To Close this Application??", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
            lbl_welcome.Visible = true;

        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Login.Enabled = true;
        }

        private void lbl_Note_Click(object sender, EventArgs e)
        {

        }

        private void lbl_welcome_Click(object sender, EventArgs e)
        {

        }

        private void lbl_login_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Username_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Password_Click(object sender, EventArgs e)
        {

        }

        private void pnl_Login_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
