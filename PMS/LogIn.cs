using Microsoft.Data.SqlClient;
using System.Security.AccessControl;

namespace PMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
        public SqlConnection con = new SqlConnection(VarStuff.conString);

        private void SignIn_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                con.Open();
                SqlCommand Scmd = new SqlCommand("SELECT count(*) FROM Employee WHERE id = @id AND password = @pswd ;", con);
                Scmd.Parameters.AddWithValue("@id", textBox1.Text);
                Scmd.Parameters.AddWithValue("@pswd", textBox2.Text);
                Scmd.ExecuteNonQuery();
                //SqlCommand isA = new SqlCommand("SELECT count(*) FROM Employee WHERE uname = @uname AND isAdmin = '1';", con);
                //isA.Parameters.AddWithValue("@uname", textBox1.Text);
                //isA.ExecuteNonQuery();
                string AccessLvl = "SELECT accessLvl FROM Employee WHERE id = @id";
                SqlCommand AccessChk = new SqlCommand(AccessLvl, con);
                AccessChk.Parameters.AddWithValue("@id", textBox1.Text);

                if (Convert.ToString(Scmd.ExecuteScalar()) == "1")
                {



                    object AcsL = AccessChk.ExecuteScalar();
                    string GetName = "SELECT name FROM Employee WHERE id = @id";
                    SqlCommand gnm = new SqlCommand(GetName, con);
                    gnm.Parameters.AddWithValue("@id", textBox1.Text);
                    object eName = gnm.ExecuteScalar();
                    VarStuff.name = eName.ToString();
                    VarStuff.empID = int.Parse(textBox1.Text);
                    if (AcsL.ToString() == "-1")
                    {
                        MessageBox.Show("Welcome " + eName.ToString());
                        adminForm af = new adminForm();
                        af.Show();
                        this.Hide();
                    }
                    else if (Convert.ToInt32(AcsL) == 1)
                    {

                        MessageBox.Show($"Welcome {eName.ToString()}");
                        EmployeeInvoiceGenerator f = new EmployeeInvoiceGenerator();
                        f.Show();
                        this.Hide();
                    }



                }
                else
                {
                    MessageBox.Show("Invalid Password Or Username");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Invalid Data");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // (char)8 is for backspace
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
