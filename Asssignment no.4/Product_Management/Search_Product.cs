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
    public partial class frm_SearchProduct : Form
    {
        public frm_SearchProduct()
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

        void clear_Details()
        {
            tb_ProductNo.Text = "";
            tb_Name.Text = "";
            tb_BuyPrice.Text = "";
            tb_SellPrice.Text = "";
            dtp_MfgDate.ResetText();
            dtp_ExpDate.ResetText();

            tb_ProductNo.Focus();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            con_Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "Select * From Product_Details where Product_No = @PNo";

            cmd.Parameters.Add("PNo", SqlDbType.Int).Value = tb_ProductNo.Text;

            SqlDataReader Dr = cmd.ExecuteReader();

            if (Dr.Read())
            {
                tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                tb_BuyPrice.Text = (Dr["Buy_Price"].ToString());
                tb_SellPrice.Text = (Dr["Sell_Price"].ToString());
                dtp_MfgDate.Text = (Dr["Mfg_Date"].ToString());
                dtp_ExpDate.Text = (Dr["Exp_Date"].ToString());
            }
            else
            {
                MessageBox.Show("Invalid Product No.", "NO Product FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_ProductNo.Clear();
            }

            con_Close();
        }

        private void btn_ProductDetails_Click(object sender, EventArgs e)
        {
            frm_ProductDetails pd = new frm_ProductDetails();
            pd.Show();
            this.Hide();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            clear_Details();
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            frm_AddProduct lf = new frm_AddProduct();
            lf.Show();
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

        private void frm_SearchProduct_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text = Shared_Content.UName;
        }
    }
}