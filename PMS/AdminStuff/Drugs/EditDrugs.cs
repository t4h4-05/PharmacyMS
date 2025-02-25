using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace PMS.AdminStuff
{
    public partial class EditDrugs : Form
    {
        public EditDrugs()
        {
            InitializeComponent();
        }

        private void EditDrugs_Load(object sender, EventArgs e)
        {
            LoadData(); // Load data when the form loads
        }

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

                    dataGridViewDrugs.DataSource = drugsTable; // Bind the data to the DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewDrugs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a row is selected
            {
                DataGridViewRow row = dataGridViewDrugs.Rows[e.RowIndex];
                txtRegNo.Text = row.Cells["Reg No"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtGName.Text = row.Cells["Generic Name"].Value.ToString();
                txtType.Text = row.Cells["Type"].Value.ToString();
                txtIPrice.Text = row.Cells["Internal Price"].Value.ToString();
                txtCPrice.Text = row.Cells["Consumer Price"].Value.ToString();
                txtQtyIS.Text = row.Cells["Quanity in Stock"].Value.ToString();
                txtTtlSold.Text = row.Cells["Total Sold"].Value.ToString();
            }
        }

        // Update/Edit a drug's data
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE Drugs 
                             SET Name = @Name, G_Name = @GName, Type = @Type, 
                                 IPrice = @IPrice, CPrice = @CPrice, QtyIS = @QtyIS 
                             WHERE Reg = @RegNo";
            string connectionString = VarStuff.conString;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@RegNo", txtRegNo.Text);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@GName", txtGName.Text);
                    cmd.Parameters.AddWithValue("@Type", txtType.Text);
                    cmd.Parameters.AddWithValue("@IPrice", Convert.ToDouble(txtIPrice.Text));
                    cmd.Parameters.AddWithValue("@CPrice", Convert.ToDouble(txtCPrice.Text));
                    cmd.Parameters.AddWithValue("@QtyIS", Convert.ToInt32(txtQtyIS.Text));

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Drug data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Refresh the grid
                    }
                    else
                    {
                        MessageBox.Show("No rows updated. Please check the data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Delete a drug record
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this drug?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string query = "DELETE FROM Drugs WHERE Reg = @RegNo";
                string connectionString = VarStuff.conString;

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@RegNo", txtRegNo.Text);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        con.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Drug deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); // Refresh the grid
                        }
                        else
                        {
                            MessageBox.Show("No rows deleted. Please check the data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Validate numeric input for price and quantity fields
        private void ValidateNumericInput(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != '.') // Allow digits, backspace, and decimal point
            {
                e.Handled = true; // Prevent invalid input
            }
        }

        private void txtIPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumericInput(e);
        }

        private void txtCPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumericInput(e);
        }

        private void txtQtyIS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // Only allow digits and backspace
            {
                e.Handled = true;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO Drugs (Name, G_Name, Type, IPrice, CPrice, QtyIS, ttlSold)
                     VALUES (@Name, @GName, @Type, @IPrice, @CPrice, @QtyIS, @TtlSold)";
            string connectionString = VarStuff.conString;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@GName", txtGName.Text);
                    cmd.Parameters.AddWithValue("@Type", txtType.Text);
                    cmd.Parameters.AddWithValue("@IPrice", Convert.ToDouble(txtIPrice.Text));
                    cmd.Parameters.AddWithValue("@CPrice", Convert.ToDouble(txtCPrice.Text));
                    cmd.Parameters.AddWithValue("@QtyIS", Convert.ToInt32(txtQtyIS.Text));
                    cmd.Parameters.AddWithValue("@TtlSold", 0); // New drugs start with 0 sold

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("New drug added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Refresh the grid with the new data
                        ClearFields(); // Clear input fields after successful addition
                    }
                    else
                    {
                        MessageBox.Show("No rows added. Please check the data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clear all input fields
        private void ClearFields()
        {
            txtRegNo.Clear();
            txtName.Clear();
            txtGName.Clear();
            txtType.Clear();
            txtIPrice.Clear();
            txtCPrice.Clear();
            txtQtyIS.Clear();
            txtTtlSold.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminForm adf = new adminForm();
            adf.Show();
            this.Hide();
        }

        private void EditDrugs_FormClosed(object sender, FormClosedEventArgs e)
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
