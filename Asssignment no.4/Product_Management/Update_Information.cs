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
    public partial class frm_UpdateInformation : Form
    {
        public frm_UpdateInformation()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection("Data Source=Ruutu;Initial Catalog=Product_Management_DB;Integrated Security=True");

        void Con_Start()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Stop()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        void Control_Enable()
        {
            tb_Name.Enabled = true;
            tb_BuyPrice.Enabled = true;
            tb_SellPrice.Enabled = true;
            dtp_MfgDate.Enabled = true;
            dtp_ExpDate.Enabled = true;
            tb_ProductNo.Enabled = false;
        }
        void Control_Disable()
        {
            tb_Name.Enabled = false;
            tb_BuyPrice.Enabled = false;
            tb_SellPrice.Enabled = false;
            dtp_MfgDate.Enabled = false;
            dtp_ExpDate.Enabled = false;
            tb_ProductNo.Enabled = true;
        }

        void Clear_Controls()
        {
            tb_ProductNo.Clear();
            tb_Name.Clear();
            tb_BuyPrice.Clear();
            tb_SellPrice.Clear();
            dtp_MfgDate.ResetText();
            dtp_ExpDate.ResetText();

            tb_ProductNo.Focus();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Start();
            if (tb_Name.Text != ""  && tb_BuyPrice.Text != "" && tb_SellPrice.Text != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;

                cmd.CommandText = "Update Product_Details Set Name = @Nm,Buy_Price = @BP,Sell_Price = @SP,Mfg_Date = @MD,Exp_Date = @ED where Product_No = @PNo";
                cmd.Parameters.Add("PNo", SqlDbType.Int).Value = tb_ProductNo.Text;
                cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("BP", SqlDbType.Int).Value = tb_BuyPrice.Text;
                cmd.Parameters.Add("SP", SqlDbType.Int).Value = tb_SellPrice.Text;
                cmd.Parameters.Add("MD", SqlDbType.Date).Value = dtp_MfgDate.Value.Date;
                cmd.Parameters.Add("ED", SqlDbType.Date).Value = dtp_ExpDate.Value.Date;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Update Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
                Control_Disable();
                tb_ProductNo.Focus();
            }
            else
            {
                MessageBox.Show("First Fill All Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            Con_Stop();
        }

        private void frm_UpdateInformation_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text = Shared_Content.UName;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Start();

            if (tb_ProductNo.Text != "")
            {
                SqlCommand cmd = new SqlCommand("select * from Product_Details where Product_No = " + tb_ProductNo.Text + "", Con);
                var obj = cmd.ExecuteReader();

                if (obj.Read())
                {
                    tb_Name.Text = obj.GetString(obj.GetOrdinal("Name"));
                    tb_BuyPrice.Text = (obj["Buy_Price"].ToString());
                    tb_SellPrice.Text = (obj["Sell_Price"].ToString());
                    dtp_MfgDate.Text = obj["Mfg_Date"].ToString();
                    dtp_ExpDate.Text = obj["Exp_Date"].ToString();

                    Control_Enable();
                }
                else
                {
                    MessageBox.Show("Invalid Product No", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_ProductNo.Clear();
                    tb_ProductNo.Focus();

                }

            }
            else
            {
                MessageBox.Show("First Fill The Product NO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con_Stop();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_ProductDetails_Click(object sender, EventArgs e)
        {
            frm_ProductDetails pd = new frm_ProductDetails();
            pd.Show();
            this.Hide();
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            frm_AddProduct ap = new frm_AddProduct();
            ap.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("You Want To LogOut??", "LOGGING OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Res == DialogResult.Yes)
            {
                frm_Login Obj = new frm_Login();
                Obj.Show();
                this.Hide();
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are you sure do you want to close this Application?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }
        private void Only_Number(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

    }
}
