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

namespace Employee_Details
{
    public partial class frm_AddEmployeeDetails : Form
    {
        public frm_AddEmployeeDetails()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ruutu;Initial Catalog=Employee_Details_DB;Integrated Security=True");
        
        void con_open()
        {
            if(con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }
        
        void con_close()
        {
            if(con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }

        private void Employee_Id(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Name(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void Mobile_no(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        void clear_details()
        {
            tb_EmployeeId.Text = "";
            tb_Name.Text = "";
            tb_MobileNo.Text = "";
            tb_Salary.Text = "";
            dtp_DOJ.ResetText();
            cb_Department.SelectedIndex = 1;

            tb_Name.Focus();
        }

        int Auto_Incr()
        {
            int Cnt = 0;

            con_open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "Select Count(*) from Employee_Details";

            Cnt = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.Dispose();

            if (Cnt > 0)
            {
                cmd.Connection = con;
                cmd.CommandText = "Select Max(Employee_Id) from Employee_Details";

                Cnt = Convert.ToInt32(cmd.ExecuteScalar());
            }
            else
            {
                Cnt = 0;
            }

            con_close();

            return Cnt + 1;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            con_open();

            if (tb_EmployeeId.Text != "" && tb_Name.Text != "" && tb_MobileNo.Text != "" && tb_Salary.Text != "" && cb_Department.Text!= "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Insert Into Employee_Details Values(@EMI,@NM,@MNo,@Slr,@DOJ,@Dpm)";
                cmd.Parameters.Add("EMI", SqlDbType.Int).Value = tb_EmployeeId.Text;
                cmd.Parameters.Add("NM", SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_MobileNo.Text;
                cmd.Parameters.Add("Slr", SqlDbType.Int).Value = tb_Salary.Text;
                cmd.Parameters.Add("DOJ", SqlDbType.Date).Value = dtp_DOJ.Text;
                cmd.Parameters.Add("Dpm", SqlDbType.VarChar).Value = cb_Department.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Insert Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Incomplete","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            con_close();
            clear_details();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            clear_details();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Do You Want To Close this Application??", "Closing", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (Res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_EmployeeDetails_Click(object sender, EventArgs e)
        {
            frm_EmployeeDetails ed = new frm_EmployeeDetails();
            ed.Show();
            this.Hide();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Do You Want To Logout??", "Logging Out", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (Res == DialogResult.Yes)
            {
                frm_LoginForm lf = new frm_LoginForm();
                lf.Show();
                this.Hide();

            }
        }

        private void frm_AddEmployeeDetails_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text = Shared_Content.UName;
            tb_EmployeeId.Text = Convert.ToString(Auto_Incr());
        }

    }
}
