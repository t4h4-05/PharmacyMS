using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace PMS.AdminStuff
{
    public partial class EditEmployee : Form
    {
        public int edit;
        public EditEmployee()
        {
            InitializeComponent();
            txtAccessLvl.Hide();
        }
        public EditEmployee(int a)
        {
            InitializeComponent();
            txtAccessLvl.Hide();
            edit = a;
            if (edit == 0) {
                btnEdit.Hide();
                btnDelete.Hide();
                label1.Hide();
                txtId.Hide();
            }
        }
        
        private readonly string connectionString = VarStuff.conString;

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT id AS UID,name AS Name,Password,age as Age,roll as \"Roll Number\",accessLvl as Access,MonthlySalary as \"Monthly Salary\",JoiningDate as \"Joining Date\" FROM Employee";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please select an employee to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = @"UPDATE Employee 
                                     SET name = @Name, 
                                         Password = @Password, 
                                         age = @Age, 
                                         roll = @Roll, 
                                         accessLvl = @AccessLvl, 
                                         MonthlySalary = @MonthlySalary
                                     WHERE id = @Id";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtId.Text));
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(txtAge.Text));
                    cmd.Parameters.AddWithValue("@Roll", txtRoll.Text);
                    cmd.Parameters.AddWithValue("@AccessLvl", Convert.ToInt32(txtAccessLvl.Text));
                    cmd.Parameters.AddWithValue("@MonthlySalary", Convert.ToDouble(txtMonthlySalary.Text));  // Add MonthlySalary

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error editing employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please select an employee to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "DELETE FROM Employee WHERE id = @Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtId.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Employee deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check if the DataGridView already contains the UID
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["UID"].Value != null && row.Cells["UID"].Value.ToString() == txtId.Text)
                {
                    MessageBox.Show("An employee with this UID already exists. Cannot add duplicate entries.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Proceed with adding the employee if the UID doesn't exist
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = @"INSERT INTO Employee (name, Password, age, roll, accessLvl, MonthlySalary, JoiningDate) 
                             VALUES (@Name, @Password, @Age, @Roll, @AccessLvl, @MonthlySalary, @JoiningDate)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(txtAge.Text));
                    cmd.Parameters.AddWithValue("@Roll", txtRoll.Text);
                    cmd.Parameters.AddWithValue("@AccessLvl", Convert.ToInt32(txtAccessLvl.Text));
                    cmd.Parameters.AddWithValue("@MonthlySalary", Convert.ToDouble(txtMonthlySalary.Text));  // Add MonthlySalary
                    cmd.Parameters.AddWithValue("@JoiningDate", DateTime.Now);  // Automatically set the Joining Date to the current date

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("New employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtId.Text = null;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM Employee WHERE name LIKE @Search OR roll LIKE @Search";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@Search", $"%{txtSearch.Text}%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearFields()
        {
            txtId.Clear();
            txtName.Clear();
            txtPassword.Clear();
            txtAge.Clear();
            txtRoll.Clear();
            txtAccessLvl.Clear();
            txtMonthlySalary.Clear();  // Clear MonthlySalary
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtId.Text = row.Cells["UID"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
                txtAge.Text = row.Cells["Age"].Value.ToString();
                txtRoll.Text = row.Cells["Roll Number"].Value.ToString();
                string aclvl = row.Cells["Access"].Value.ToString();
                txtAccessLvl.Text = aclvl;
                if (aclvl == "1")
                {
                    rb_isE.Checked = true;
                    rb_isA.Checked = false;
                }
                else
                {
                    rb_isA.Checked = true;
                    rb_isE.Checked = false;
                }
                txtMonthlySalary.Text = row.Cells["Monthly Salary"].Value.ToString();  // Populate MonthlySalary
            }
        }

        private void btnClrID_Click(object sender, EventArgs e)
        {
            txtId.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminForm adf = new adminForm();
            adf.Show();
            this.Hide();
        }

        private void EditEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            adminForm a1 = new adminForm();
            a1.Show();
        }

        private void rb_isA_CheckedChanged(object sender, EventArgs e)
        {
            txtAccessLvl.Text = "-1";
        }

        private void rb_isE_CheckedChanged(object sender, EventArgs e)
        {
            txtAccessLvl.Text = "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminEmployee adf = new AdminEmployee();
            adf.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AdminEmployee adf = new AdminEmployee();
            adf.Show();
            this.Hide();
        }
    }
}
