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

namespace StudentDetails2
{
    public partial class frm_AddStudentDetails : Form
    {
        public frm_AddStudentDetails()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=Ruutu;Initial Catalog=Admission_System_App_DB;Integrated Security=True");
        void con_open()
        {
            if(con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }

        
        void con_close()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }

        void clear_controls()
        {
            tb_RollNo.Text = "";
            tb_Name.Text = "";
            tb_MobileNo.Text = "";
            cmb_Course.Text = "";
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            con_open();
            if (tb_RollNo.Text != "" && tb_Name.Text != "" && tb_MobileNo.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Insert Into Student_Details Values(@RNo,@Name,@MNo,@DOB,@Course)";
                cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_RollNo.Text;
                cmd.Parameters.Add("Name", SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_MobileNo.Text;
                cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Text;
                cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Insert Successfull ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Incomplete Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }

            clear_controls();
        }

        private void btn_StudentList_Click(object sender, EventArgs e)
        {
            frm_StudentDetails sd = new frm_StudentDetails();
            sd.Show();
            this.Hide();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            clear_controls();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            frm_LoginForm lf = new frm_LoginForm();
            lf.Show();
            this.Hide();
        }
    }
}
