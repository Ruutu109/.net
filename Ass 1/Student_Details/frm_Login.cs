using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Details
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void lbl_Username_Click(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            frm_AddStudentDetails obj = new frm_AddStudentDetails();
            obj.Show();
            this.Hide();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
