using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace PMS.AdminStuff
{
    public partial class ViewSales : Form
    {
        private DataTable salesTable; // Store the data globally for filtering

        public ViewSales()
        {
            InitializeComponent();
        }

        private void ViewSales_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            adminForm a1 = new adminForm();
            a1.Show();
        }

        private void LoadData()
        {
            string query = "SELECT Id as ID, Date as \"Date Of Sale\", EmpID AS \"Employee ID\", " +
                           "total_sales AS \"Qty Sold\", total_revenue AS \"Revenue At Sale\", " +
                           "total_profit AS \"Profit from Sale\", items AS \"Invoice\" FROM Sales";
            string connectionString = VarStuff.conString;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    salesTable = new DataTable();
                    adapter.Fill(salesTable);

                    dataGridView1.DataSource = salesTable; // Bind the DataTable to the DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewSales_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (salesTable != null) // Ensure data is loaded
            {
                string filterText = txtFilter.Text;
                string filterExpression = $"Convert(ID, 'System.String') LIKE '%{filterText}%' " +
                                          $"OR Convert([Date Of Sale], 'System.String') LIKE '%{filterText}%'";

                DataView dv = new DataView(salesTable);
                dv.RowFilter = filterExpression;
                dataGridView1.DataSource = dv; // Bind filtered data
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminForm a1 = new adminForm();
            a1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminForm a1 = new adminForm();
            a1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminStuff.AdminSales a1 = new AdminSales();
            a1.Show();
        }
    }
}
