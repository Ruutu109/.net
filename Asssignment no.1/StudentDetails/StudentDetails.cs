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
    public partial class frm_StudentDetails : Form
    {
        public frm_StudentDetails()
        {
            InitializeComponent();
        }

        private void frm_StudentDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'admission_System_App_DBDataSet.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.admission_System_App_DBDataSet.Student_Details);

        }

        private void btn_StudentList_Click(object sender, EventArgs e)
        {
            frm_AddStudentDetails asd = new frm_AddStudentDetails();
            asd.Show();
            this.Hide();
        }
    }
}
