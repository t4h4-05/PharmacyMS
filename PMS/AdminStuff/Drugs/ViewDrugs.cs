using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace PMS.AdminStuff
{
    public partial class ViewDrugs : Form
    {
        public ViewDrugs()
        {
            InitializeComponent();

        }

        // Load all data when the form loads or when the "Load Data" button is clicked
        private void LoadData()
        {
            string query = "SELECT reg AS \"Reg No\",Name,G_Name AS \"Generic Name\",Type,IPrice AS \"Internal Price\",CPrice AS \"Consumer Price\",QtyIS AS \"Quanity in Stock\",ttlSold AS \"Total Sold\" FROM Drugs";
            string connectionString = VarStuff.conString;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable drugsTable = new DataTable();
                    adapter.Fill(drugsTable);

                    dataGridView1.DataSource = drugsTable; // Bind the DataTable to the DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Search data based on user input
        private void SearchData(string searchText)
        {
            string query = "SELECT reg AS \"Reg No\",Name,G_Name AS \"Generic Name\",Type,IPrice AS \"Internal Price\",CPrice AS \"Consumer Price\",QtyIS AS \"Quanity in Stock\",ttlSold AS \"Total Sold\" FROM Drugs WHERE Name LIKE @Search OR CAST(Reg AS varchar) LIKE @Search";
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

        private void ViewDrugs_Load(object sender, EventArgs e)
        {
            LoadData(); // Automatically load all data when the form loads
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminForm adf = new adminForm();
            adf.Show();
            this.Hide();
        }

        private void ViewDrugs_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            adminForm a1 = new adminForm();
            a1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminStuff.AdminDrugs adf = new AdminStuff.AdminDrugs();
            adf.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AdminStuff.AdminDrugs adf = new AdminStuff.AdminDrugs();
            adf.Show();
            this.Hide();
        }
    }
}
