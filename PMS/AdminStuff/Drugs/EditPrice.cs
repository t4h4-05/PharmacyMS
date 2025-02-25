using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PMS.AdminStuff.Drugs
{
    public partial class EditPrice : Form
    {
        // Connection string (use VarStuff.conString)
        private string connectionString = VarStuff.conString;

        public EditPrice()
        {
            InitializeComponent();
            LoadData();
        }

        // Load data into the DataGridView
        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Query to get necessary data
                    string query = "SELECT Reg, Name, IPrice, CPrice FROM Drugs";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Bind data to DataGridView
                    dataGridView1.DataSource = dt;

                    // Set custom column headers
                    dataGridView1.Columns["IPrice"].HeaderText = "Internal Price";
                    dataGridView1.Columns["CPrice"].HeaderText = "Consumer Price";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        // Handle cell click to populate text boxes
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the click is on a valid row
            {
                try
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // Populate text boxes
                    txtName.Text = row.Cells["Name"].Value.ToString();
                    txtIPrice.Text = row.Cells["IPrice"].Value.ToString();
                    txtCPrice.Text = row.Cells["CPrice"].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error selecting row: {ex.Message}");
                }
            }
        }

        // Save the updated prices to the database
        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    // Get selected row's Reg value
                    int reg = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Reg"].Value);

                    // Get updated values
                    string name = txtName.Text;
                    float internalPrice = float.Parse(txtIPrice.Text);
                    float consumerPrice = float.Parse(txtCPrice.Text);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        // Update query
                        string query = "UPDATE Drugs SET Name = @Name, IPrice = @IPrice, CPrice = @CPrice WHERE Name = @Name";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@IPrice", internalPrice);
                        cmd.Parameters.AddWithValue("@CPrice", consumerPrice);
                        cmd.Parameters.AddWithValue("@Reg", reg);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    MessageBox.Show("Record updated successfully!");

                    // Refresh data in DataGridView
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving changes: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }



        private void EditPrice_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminDrugs adminDrugs = new AdminDrugs();
            adminDrugs.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDrugs adminDrugs = new AdminDrugs();
            adminDrugs.Show();
            this.Hide();
        }

        private void EditPrice_Load(object sender, EventArgs e)
        {

        }
    }
}
