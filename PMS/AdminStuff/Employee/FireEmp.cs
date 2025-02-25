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

namespace PMS.AdminStuff.Employee
{
    public partial class FireEmp : Form
    {
        public FireEmp()
        {
            InitializeComponent();
        }
        private string connectionString = VarStuff.conString;

        // Load all employees into DataGridView
        private void LoadData()
        {
            string query = "SELECT id AS \"Employee ID\", name AS \"Name\", age AS \"Age\", accessLvl AS \"Access Level\", MonthlySalary AS \"Monthly Salary\", JoiningDate AS \"Joining Date\" FROM Employee";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable employeeTable = new DataTable();
                    adapter.Fill(employeeTable);
                    dataGridView1.DataSource = employeeTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Delete employee based on selection
        private void btnFire_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee to fire.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get selected employee's ID
            int empID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Employee ID"].Value);

            // Confirm deletion
            DialogResult confirm = MessageBox.Show($"Are you sure you want to fire Employee ID {empID}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Delete the employee
                    string deleteEmployeeQuery = "DELETE FROM Employee WHERE id = @EmpID";

                    using (SqlCommand cmd = new SqlCommand(deleteEmployeeQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@EmpID", empID);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Employee ID {empID} has been successfully fired.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); // Refresh DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to fire the employee. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error firing employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FireEmployees_Load(object sender, EventArgs e)
        {
            LoadData(); // Load all employees on form load
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminEmployee ae = new AdminEmployee();
            ae.Show();
            this.Hide();
        }
    }
}