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
    public partial class frm_AddProduct : Form
    {
        public frm_AddProduct()
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
            tb_Name.Text = "";
            tb_BuyPrice.Text = "";
            tb_SellPrice.Text = "";
            dtp_MfgDate.ResetText();
            dtp_ExpDate.ResetText();

            tb_Name.Focus();
        }

        private void Product_No(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Product_Name(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void Buying_Price(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Selling_Price(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        int Auto_Incr()
        {
            int cnt = 0;

            con_Open();

            SqlCommand cmd = new SqlCommand("Select Count(Product_No) from Product_Details", con);

            cnt = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.Dispose();

            if (cnt > 0)
            {
                cmd.Connection = con;
                cmd.CommandText = "Select Max(Product_No) From Product_Details";

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

            if (tb_ProductNo.Text != "" && tb_Name.Text != "" && tb_BuyPrice.Text != "" && tb_SellPrice.Text != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Insert Into Product_Details Values(@PNo,@Nm,@BP,@SP,@MD,@ED)";
                cmd.Parameters.Add("PNo", SqlDbType.Int).Value = tb_ProductNo.Text;
                cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("BP", SqlDbType.Int).Value = tb_BuyPrice.Text;
                cmd.Parameters.Add("SP", SqlDbType.Int).Value = tb_SellPrice.Text;
                cmd.Parameters.Add("MD", SqlDbType.Date).Value = dtp_MfgDate.Text;
                cmd.Parameters.Add("ED", SqlDbType.Date).Value = dtp_ExpDate.Text;

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

        private void btn_ProductDetails_Click(object sender, EventArgs e)
        {
            frm_ProductDetails pd = new frm_ProductDetails();
            pd.Show();
            this.Hide();
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

        private void btn_SearchPatient_Click(object sender, EventArgs e)
        {
            frm_SearchProduct sp = new frm_SearchProduct();
            sp.Show();
            this.Hide();
        }

        private void frm_AddProduct_Load(object sender, EventArgs e)
        {
            lbl_User.Text = Shared_Content.UName;
            tb_ProductNo.Text = Convert.ToString(Auto_Incr());
        }
    }
}
