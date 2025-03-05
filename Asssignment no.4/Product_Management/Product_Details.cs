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

namespace Product_Management
{
    public partial class frm_ProductDetails : Form
    {
        public frm_ProductDetails()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=Ruutu;Initial Catalog=Product_Management_DB;Integrated Security=True");

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

        private void frm_ProductDetails_Load(object sender, EventArgs e)
        {
            this.product_DetailsTableAdapter.Fill(this.product_Management_DBDataSet.Product_Details);

            lbl_welcome.Text = Shared_Content.UName;

            con_Open();

            dgv_ProductDetails.DataSource = "";

            SqlDataAdapter sda = new SqlDataAdapter("Select * from Product_Details", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgv_ProductDetails.DataSource = dt;

            con_Close();
        }
        
        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            frm_AddProduct ap = new frm_AddProduct();
            ap.Show();
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            frm_SearchProduct spd = new frm_SearchProduct();
            spd.Show();
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
                frm_Login lf = new frm_Login();
                lf.Show();
                this.Hide();
            }
        }

        private void btn_UpdateInformation_Click(object sender, EventArgs e)
        {
            frm_UpdateInformation ui = new frm_UpdateInformation();
            ui.Show();
            this.Hide();
        }
    }
}