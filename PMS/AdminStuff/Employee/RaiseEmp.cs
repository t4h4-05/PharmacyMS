using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.AdminStuff.Employee
{
    public partial class RaiseEmp : Form
    {
        public RaiseEmp()
        {
            InitializeComponent();
        }
        private string connectionString = VarStuff.conString;

        // Load employee data into DataGridView
        private void LoadData()
        {
            string query = "SELECT id AS 'Employee ID', name AS 'Name', age AS 'Age', MonthlySalary AS 'Current Salary', JoiningDate AS 'Joining Date' FROM Employee";
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

        // Apply the raise to the selected employee
        private void btnApplyRaise_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an employee.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRaiseAmount.Text) || !decimal.TryParse(txtRaiseAmount.Text, out decimal raiseAmount) || raiseAmount <= 0)
            {
                MessageBox.Show("Please enter a valid positive raise amount.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get selected employee's ID
            int empID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Employee ID"].Value);

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Update the employee's salary
                    string updateSalaryQuery = "UPDATE Employee SET MonthlySalary = MonthlySalary + @RaiseAmount WHERE id = @EmpID";
                    using (SqlCommand cmd = new SqlCommand(updateSalaryQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@RaiseAmount", raiseAmount);
                        cmd.Parameters.AddWithValue("@EmpID", empID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Successfully applied a raise of Rs.{raiseAmount} to Employee ID {empID}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); // Refresh DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to apply the raise. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying raise: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GiveRaise_Load(object sender, EventArgs e)
        {
            LoadData(); // Load all employees on form load
        }

        private void RaiseEmp_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminEmployee adminEmployee = new AdminEmployee();
            adminEmployee.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminEmployee ae = new AdminEmployee();
            ae.Show();
            this.Hide();
        }
    }
}