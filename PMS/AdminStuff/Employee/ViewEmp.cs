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

namespace PMS.AdminStuff
{
    public partial class ViewEmp : Form
    {
        public ViewEmp()
        {
            InitializeComponent();
        }
        // Load all data when the form loads or when the "Load Data" button is clicked
        private void LoadData()
        {
            string query = "SELECT id AS \"Employee ID\", name AS \"Name\", Password AS \"Password\", age AS \"Age\", accessLvl AS \"Access Level\", MonthlySalary AS \"Monthly Salary\", JoiningDate AS \"Joining Date\" FROM Employee";
            string connectionString = VarStuff.conString;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable employeeTable = new DataTable();
                    adapter.Fill(employeeTable);

                    dataGridView1.DataSource = employeeTable; // Bind the DataTable to the DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Search data based on user input (search by ID or Name)
        private void SearchData(string searchText)
        {
            string query = "SELECT id AS \"Employee ID\", name AS \"Name\", Password AS \"Password\", age AS \"Age\", accessLvl AS \"Access Level\", MonthlySalary AS \"Monthly Salary\", JoiningDate AS \"Joining Date\" FROM Employee WHERE name LIKE @Search OR CAST(id AS varchar) LIKE @Search";
            string connectionString = VarStuff.conString;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Search", $"%{searchText}%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable searchResults = new DataTable();
                    adapter.Fill(searchResults);

                    dataGridView1.DataSource = searchResults; // Update DataGridView with search results
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            txtSearch.Text = null;
            LoadData(); // Load all data
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                SearchData(txtSearch.Text); // Search data based on the TextBox value
            }
            else
            {
                MessageBox.Show("Please enter a value to search.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ViewEmployees_Load(object sender, EventArgs e)
        {
            LoadData(); // Automatically load all data when the form loads
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminEmployee a1 = new AdminEmployee();
            this.Hide();
            a1.Show();
        }

        private void ViewEmployees_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminEmployee a1 = new AdminEmployee();
            this.Hide();           
            a1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminStuff.AdminEmployee adf = new AdminStuff.AdminEmployee();
            adf.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AdminStuff.AdminEmployee adf = new AdminStuff.AdminEmployee();
            adf.Show();
            this.Hide();
        }
    }
}