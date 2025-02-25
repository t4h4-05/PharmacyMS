using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
namespace PMS.AdminStuff
{
    public partial class AddDrugs : Form
    {
        public AddDrugs()
        {
            InitializeComponent();
        }
        public SqlConnection con = new SqlConnection(VarStuff.conString);
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Missing Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                con.Open();
                SqlCommand insrtDrg = new SqlCommand($"INSERT INTO [dbo].[Drugs] ([Name], [G_Name], [Type], [IPrice], [CPrice], [QtyIS], [ttlSold]) VALUES ('{textBox1.Text.ToString()}', '{textBox2.Text.ToString()}', '{textBox6.Text.ToString()}', {Convert.ToInt32(textBox3.Text)}, {Convert.ToInt32(textBox5.Text)}, {Convert.ToInt32(textBox4.Text)}, {0});", con);
                object DataInserted = insrtDrg.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Sucessfully");
                this.Close();

            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }


        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // (char)8 is for backspace
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void AddDrugs_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminForm adf = new adminForm();
            adf.Show();
            this.Hide();
        }

        private void AddDrugs_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            adminForm a1 = new adminForm();
            a1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDrugs a1 = new AdminDrugs();
            a1.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AdminDrugs a1 = new AdminDrugs();
            a1.Show();
        }
    }
}
