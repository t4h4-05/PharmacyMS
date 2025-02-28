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

namespace PMS
{
    public partial class EmployeeInvoiceGenerator : Form
    {
        public EmployeeInvoiceGenerator()
        {
            InitializeComponent();
            lblWelcome.Text = $"Welcome {VarStuff.name}";

            // Make sure txtReg and txtName are editable
            txtReg.ReadOnly = false;
            txtName.ReadOnly = false;

            // Wire up the TextChanged events
            txtReg.TextChanged += txtReg_TextChanged;
            txtName.TextChanged += txtName_TextChanged;

            // Optional: Enable overwrite mode by default
            txtReg.KeyPress += TextBox_KeyPress;
            txtName.KeyPress += TextBox_KeyPress;
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // If there's selected text, pressing a key will overwrite it
            if (textBox.SelectionLength > 0 && char.IsLetterOrDigit(e.KeyChar))
            {
                // Let the default behavior handle it (which will replace the selection)
                return;
            }
        }
        private string con = VarStuff.conString;
        private List<string> invoiceItems = new List<string>();
        private decimal totalPrice = 0;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void LoadDrugsData(string search = "")
        {
            using (SqlConnection con = new SqlConnection(VarStuff.conString))
            {
                try
                {
                    string query = string.IsNullOrWhiteSpace(search)
                        ? "SELECT Reg, Name, Type, CPrice AS Price, QtyIS AS Stock FROM Drugs"
                        : "SELECT Reg, Name, Type, CPrice AS Price, QtyIS AS Stock FROM Drugs WHERE Name LIKE @Search OR Reg LIKE @Search";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    if (!string.IsNullOrWhiteSpace(search))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@Search", $"%{search}%");
                    }

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    //dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //LoadDrugsData(txtSearch.Text);
        }

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        //DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
        //        txtReg.Text = row.Cells["Reg"].Value.ToString();
        //        txtName.Text = row.Cells["Name"].Value.ToString();
        //        txtType.Text = row.Cells["Type"].Value.ToString();
        //        txtPrice.Text = row.Cells["Price"].Value.ToString();
        //        txtQty.Text = "1";
        //    }
        //}

        private void btnAddToInvoice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please select a drug to add to the invoice.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtQty.Text) || !int.TryParse(txtQty.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Please provide a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(VarStuff.conString))
            {
                try
                {
                    // Check available stock
                    con.Open();
                    string checkStockQuery = "SELECT QtyIS FROM Drugs WHERE Name = @Name";
                    SqlCommand checkStockCmd = new SqlCommand(checkStockQuery, con);
                    checkStockCmd.Parameters.AddWithValue("@Name", txtName.Text);

                    object result = checkStockCmd.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("Drug not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int availableQty = Convert.ToInt32(result);
                    if (availableQty < qty)
                    {
                        MessageBox.Show("Insufficient stock available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Calculate the price with discount
                    decimal price = Convert.ToDecimal(txtPrice.Text);
                    decimal discount = 0;

                    if (!string.IsNullOrWhiteSpace(txtDiscount.Text) && decimal.TryParse(txtDiscount.Text, out discount))
                    {
                        price -= (price * discount / 100);
                    }

                    decimal totalItemPrice = price * qty;

                    // Reduce stock in the database
                    //string reduceStockQuery = "UPDATE Drugs SET QtyIS = QtyIS - @Qty WHERE Name = @Name";
                    //SqlCommand reduceStockCmd = new SqlCommand(reduceStockQuery, con);
                    //reduceStockCmd.Parameters.AddWithValue("@Qty", qty);
                    //reduceStockCmd.Parameters.AddWithValue("@Name", txtName.Text);
                    //reduceStockCmd.ExecuteNonQuery();

                    
                    string invoiceItem = $"{txtReg.Text} {txtName.Text} (Qty: {qty}, Price: Rs{totalItemPrice})";
                    invoiceItems.Add(invoiceItem);

                    listBoxInvoice.Items.Add(invoiceItem);
                    totalPrice += totalItemPrice;

                    lblTotalPrice.Text = $"Total Price: Rs{totalPrice}";
                    //MessageBox.Show("Item added to invoice and stock updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (invoiceItems.Count == 0)
            {
                MessageBox.Show("No items in the invoice to print!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DateTime currentDate = DateTime.Now;
                int totalSales = 0;
                decimal totalRevenue = 0;
                decimal totalProfit = 0;

                foreach (string item in invoiceItems)
                {
                    var parts = item.Split(' ');
                    if (!int.TryParse(parts[0], out int regNo))
                    {
                        MessageBox.Show($"Invalid RegNo format in item: {item}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    var qtyPart = item.Split(':')[1].Split(',')[0].Trim();
                    if (!int.TryParse(qtyPart, out int qty))
                    {
                        MessageBox.Show($"Invalid Qty format in item: {item}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    using (SqlConnection con = new SqlConnection(VarStuff.conString))
                    {
                        con.Open();

                        string fetchPriceQuery = "SELECT CPrice, IPrice FROM Drugs WHERE Reg = @RegNo";
                        SqlCommand fetchPriceCmd = new SqlCommand(fetchPriceQuery, con);
                        fetchPriceCmd.Parameters.AddWithValue("@RegNo", regNo);

                        decimal cPrice = 0, iPrice = 0;
                        using (SqlDataReader reader = fetchPriceCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cPrice = Convert.ToDecimal(reader["CPrice"]);
                                iPrice = Convert.ToDecimal(reader["IPrice"]);
                            }
                            else
                            {
                                MessageBox.Show($"Drug with RegNo {regNo} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                continue;
                            }
                        }

                        decimal discount = string.IsNullOrWhiteSpace(txtDiscount.Text)
                            ? 0
                            : decimal.TryParse(txtDiscount.Text, out var d) ? d : throw new FormatException("Invalid discount format.");

                        decimal finalPrice = cPrice - (cPrice * discount / 100);
                        decimal profitPerUnit = finalPrice - iPrice;
                        decimal itemRevenue = finalPrice * qty;
                        decimal itemProfit = profitPerUnit * qty;

                        totalRevenue += itemRevenue;
                        totalProfit += itemProfit;
                        totalSales += qty;

                        string updateQtyQuery = "UPDATE Drugs SET QtyIS = QtyIS - @Qty, ttlSold = ttlSold + @Qty WHERE Reg = @RegNo";
                        SqlCommand updateQtyCmd = new SqlCommand(updateQtyQuery, con);
                        updateQtyCmd.Parameters.AddWithValue("@Qty", qty);
                        updateQtyCmd.Parameters.AddWithValue("@RegNo", regNo);
                        updateQtyCmd.ExecuteNonQuery();

                        string insertItemQuery = @"
                    INSERT INTO [dbo].[Sales] ([Date], [EmpID], [total_sales], [total_revenue], [total_profit], [items]) 
                    VALUES (@Date, @EmpID, @Qty, @Revenue, @Profit, @Item)";

                        SqlCommand insertItemCmd = new SqlCommand(insertItemQuery, con);
                        insertItemCmd.Parameters.AddWithValue("@Date", currentDate);
                        insertItemCmd.Parameters.AddWithValue("@EmpID", VarStuff.empID);
                        insertItemCmd.Parameters.AddWithValue("@Qty", qty);
                        insertItemCmd.Parameters.AddWithValue("@Revenue", itemRevenue);
                        insertItemCmd.Parameters.AddWithValue("@Profit", itemProfit);
                        insertItemCmd.Parameters.AddWithValue("@Item", item);

                        insertItemCmd.ExecuteNonQuery();
                    }
                }

                string fileName = $"Invoice_{currentDate:yyyyMMdd_HHmmss}_{VarStuff.name}.txt";
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName);

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Invoice Items:");
                    foreach (string item in invoiceItems)
                    {
                        writer.WriteLine(item);
                    }
                    writer.WriteLine($"Total Price: Rs{totalRevenue}");
                }

                MessageBox.Show($"Invoice saved successfully to {filePath}", "Invoice Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                invoiceItems.Clear();
                listBoxInvoice.Items.Clear();
                totalPrice = 0;
                lblTotalPrice.Text = "Total Price: Rs0";
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Formatting error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadDrugsData();
        }



        private void ClearFields()
        {
            txtReg.Clear();
            txtName.Clear();
            txtType.Clear();
            txtPrice.Clear();
            txtDiscount.Clear();
            txtQty.Clear();
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // (char)8 is for backspace
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // (char)8 is for backspace
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }

        private void EmployeeInvoiceGenerator_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (listBoxInvoice.SelectedItem == null)
            {
                MessageBox.Show("Please select an item to delete from the invoice.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected item
            string selectedItem = listBoxInvoice.SelectedItem.ToString();

            try
            {
                // Debug the selected item format
                MessageBox.Show(selectedItem, "Debug - Selected Item");

                // Expected format: "ItemName (Qty: X, Price: $YY.YY)"
                // Split the selected item string
                var parts = selectedItem.Split(',');

                // Extract the price part from the split data
                var pricePart = parts.FirstOrDefault(p => p.Trim().StartsWith("Price:"));
                if (pricePart != null)
                {
                    // Clean up the price string to remove "Price: $" and trailing ")"
                    string priceStr = pricePart.Trim().Replace("Price:", "").Replace("Rs", "").Replace(")", "").Trim();

                    if (decimal.TryParse(priceStr, out decimal itemPrice))
                    {
                        // Subtract the price from the total
                        totalPrice -= itemPrice;
                        lblTotalPrice.Text = $"Total Price: Rs{totalPrice}";
                    }
                    else
                    {
                        MessageBox.Show($"Could not parse price: {priceStr}", "Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Remove the item from the list
                    listBoxInvoice.Items.Remove(selectedItem);
                    invoiceItems.Remove(selectedItem);

                    MessageBox.Show("Item removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Price information is missing or in an invalid format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtReg_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtReg.Text))
            {
                // Save current cursor position
                int cursorPosition = txtReg.SelectionStart;

                AutocompleteFromDatabase("Reg", txtReg.Text);

                // Restore cursor position and set selection length for overwrite mode
                if (txtReg.Text.Length > cursorPosition)
                {
                    txtReg.SelectionStart = cursorPosition;
                    txtReg.SelectionLength = txtReg.Text.Length - cursorPosition;
                }
            }
            else
            {
                ClearOtherFields("Reg");
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                // Save current cursor position
                int cursorPosition = txtName.SelectionStart;

                AutocompleteFromDatabase("Name", txtName.Text);

                // Restore cursor position and set selection length for overwrite mode
                if (txtName.Text.Length > cursorPosition)
                {
                    txtName.SelectionStart = cursorPosition;
                    txtName.SelectionLength = txtName.Text.Length - cursorPosition;
                }
            }
            else
            {
                ClearOtherFields("Name");
            }
        }

        private void AutocompleteFromDatabase(string fieldType, string value)
        {
            // Don't trigger nested autocomplete
            txtReg.TextChanged -= txtReg_TextChanged;
            txtName.TextChanged -= txtName_TextChanged;

            using (SqlConnection con = new SqlConnection(VarStuff.conString))
            {
                try
                {
                    con.Open();
                    string query = $"SELECT TOP 1 Reg, Name, Type, CPrice AS Price FROM Drugs WHERE {fieldType} LIKE @Search";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Search", $"{value}%");

                    bool foundMatch = false;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            foundMatch = true;
                            string oldRegText = txtReg.Text;
                            string oldNameText = txtName.Text;

                            // Update all fields except the one being typed in
                            if (fieldType != "Reg") txtReg.Text = reader["Reg"].ToString();
                            if (fieldType != "Name") txtName.Text = reader["Name"].ToString();
                            txtType.Text = reader["Type"].ToString();
                            txtPrice.Text = reader["Price"].ToString();
                            txtQty.Text = "1"; // Default quantity

                            // For the field being typed in, only update if it's a completion of what's already typed
                            if (fieldType == "Reg" && reader["Reg"].ToString().StartsWith(oldRegText))
                            {
                                txtReg.Text = reader["Reg"].ToString();
                            }

                            if (fieldType == "Name" && reader["Name"].ToString().StartsWith(oldNameText))
                            {
                                txtName.Text = reader["Name"].ToString();
                            }
                        }
                    }

                    // If no match found, clear other fields
                    if (!foundMatch)
                    {
                        ClearOtherFields(fieldType);
                    }
                }
                catch (Exception ex)
                {
                    // Optionally handle errors silently
                }
                finally
                {
                    // Re-attach the event handlers
                    txtReg.TextChanged += txtReg_TextChanged;
                    txtName.TextChanged += txtName_TextChanged;
                }
            }
        }

        private void ClearOtherFields(string exceptField)
        {
            // Don't trigger nested events
            txtReg.TextChanged -= txtReg_TextChanged;
            txtName.TextChanged -= txtName_TextChanged;

            try
            {
                // Clear all fields except the one specified
                if (exceptField != "Reg") txtReg.Text = "";
                if (exceptField != "Name") txtName.Text = "";
                txtType.Text = "";
                txtPrice.Text = "";
                txtQty.Text = "";
                txtDiscount.Text = "";
            }
            finally
            {
                // Re-attach the event handlers
                txtReg.TextChanged += txtReg_TextChanged;
                txtName.TextChanged += txtName_TextChanged;
            }
        }


        //private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter && dataGridView1.CurrentCell != null)
        //    {
        //        // Prevent the default behavior of the Enter key
        //        e.Handled = true;

        //        // Trigger the CellClick event for the current cell
        //        var rowIndex = dataGridView1.CurrentCell.RowIndex;
        //        var colIndex = dataGridView1.CurrentCell.ColumnIndex;

        //        dataGridView1_CellClick(this, new DataGridViewCellEventArgs(colIndex, rowIndex));
        //    }
        //}

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void txtReg_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void listBoxInvoice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
