using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Details
{
    public partial class frm_EmployeeDetails : Form
    {
        public frm_EmployeeDetails()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_Details_DBDataSet2.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter2.Fill(this.employee_Details_DBDataSet2.Employee_Details);

        }

        private void btn_AddEmployeeDetails_Click(object sender, EventArgs e)
        {
            frm_AddEmployeeDetails aed = new frm_AddEmployeeDetails();
            aed.Show();
            this.Hide();
        }

        
        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Do You Want To Close this Application??", "Closing", MessageBoxButtons.YesNo);

            if (Res == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Do You Want To Logout??", "Logging Out", MessageBoxButtons.YesNo);

            if (Res == DialogResult.Yes)
            {
                frm_LoginForm lf = new frm_LoginForm();
                lf.Show();
                this.Hide();

            }
        }
    }
}
