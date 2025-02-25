using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PMS.AdminStuff
{
    public partial class AddStock : Form
    {
        public AddStock()
        {
            InitializeComponent();
            button1.Text = "Add or Remove";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // (char)8 is for backspace
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // (char)8 is for backspace
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please fill out both fields (Reg No and Amount).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!addDrugs.Checked && !remDrugs.Checked)
            {
                MessageBox.Show("Please select an operation (Add or Remove).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int regNo = Convert.ToInt32(textBox1.Text);
            int amount = Convert.ToInt32(textBox2.Text);

            try
            {
                using (SqlConnection con = new SqlConnection(VarStuff.conString))
                {
                    con.Open();

                    // Retrieve the current QtyIS value
                    string getQtyQuery = "SELECT QtyIS FROM Drugs WHERE Reg = @RegNo";
                    SqlCommand getQtyCmd = new SqlCommand(getQtyQuery, con);
                    getQtyCmd.Parameters.AddWithValue("@RegNo", regNo);

                    object result = getQtyCmd.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("Drug with the provided Reg No does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int currentQty = Convert.ToInt32(result);
                    int newQty = currentQty;

                    // Add or Remove stock based on the selected RadioButton
                    if (addDrugs.Checked) // Add
                    {
                        newQty += amount;
                    }
                    else if (remDrugs.Checked) // Remove
                    {
                        if (currentQty < amount)
                        {
                            MessageBox.Show("Not enough stock to remove the specified amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        newQty -= amount;
                    }

                    // Update the QtyIS value in the database
                    string updateQtyQuery = "";

                    if (addDrugs.Checked) // Add
                    {
                        updateQtyQuery = "UPDATE Drugs SET QtyIS = QtyIS + @Amount WHERE Reg = @RegNo";
                        button1.Text = "Add drugs";
                    }
                    else if (remDrugs.Checked) // Remove
                    {
                        updateQtyQuery = "UPDATE Drugs SET QtyIS = QtyIS - @Amount WHERE Reg = @RegNo";
                        button1.Text = "Remove drugs";
                    }

                    SqlCommand updateQtyCmd = new SqlCommand(updateQtyQuery, con);
                    updateQtyCmd.Parameters.AddWithValue("@Amount", amount);
                    updateQtyCmd.Parameters.AddWithValue("@RegNo", regNo);

                    int rowsAffected = updateQtyCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Stock successfully updated! New QtyIS: {newQty}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update the stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddStock_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminForm adf = new adminForm();
            adf.Show();
            this.Hide();
        }

        private void AddStock_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            adminForm a1 = new adminForm();
            a1.Show();
        }

        private void addDrugs_CheckedChanged(object sender, EventArgs e)
        {
            button1.Text = "Add Stock";
        }

        private void remDrugs_CheckedChanged(object sender, EventArgs e)
        {
            button1.Text = "Remove Stock";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminStuff.AdminDrugs adf = new AdminStuff.AdminDrugs();
            adf.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AdminStuff.AdminDrugs adf = new AdminStuff.AdminDrugs();
            adf.Show();
            this.Hide();
        }
    }
}
