using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDetails2
{
    public partial class frm_LoginForm : Form
    {
        public frm_LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(tb_Username.Text=="R" && tb_Password.Text=="R")
            {
                frm_AddStudentDetails asd = new frm_AddStudentDetails();
                    asd.Show();
                    this.Hide();
                
            }
        }

        
    }
}
