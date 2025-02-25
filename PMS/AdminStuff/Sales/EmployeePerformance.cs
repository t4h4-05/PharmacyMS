using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PMS.AdminStuff
{
    public partial class EmployeePerformance : Form
    {
        public EmployeePerformance()
        {
            InitializeComponent();
        }

        private void EmployeePerformance_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }

        // Load employee data into DataGridView
        private void LoadEmployeeData(string searchQuery = "")
        {
            using (SqlConnection con = new SqlConnection(VarStuff.conString))
            {
                con.Open();

                // Corrected query with proper condition grouping and filtering by accessLvl = 1
                string query = "SELECT e.id, e.name, ISNULL(SUM(s.total_sales), 0) AS TotalSales, " +
                               "ISNULL(SUM(s.total_revenue), 0) AS TotalRevenue, ISNULL(SUM(s.total_profit), 0) AS TotalProfit " +
                               "FROM Employee e " +
                               "LEFT JOIN Sales s ON e.id = s.EmpID " +
                               "WHERE e.accessLvl = 1 AND (e.name LIKE @SearchQuery OR e.id LIKE @SearchQuery) " +
                               "GROUP BY e.id, e.name";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@SearchQuery", $"%{searchQuery}%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Bind data to DataGridView
                dataGridViewEmployee.DataSource = dt;
            }
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Reload the employee data with the search query
            LoadEmployeeData(txtSearch.Text);
        }

        // Handle row selection in DataGridView
        private void dataGridViewEmployee_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEmployee.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewEmployee.SelectedRows[0];

                // Populate labels with employee data
                lblEmpID.Text = $"Employee ID: {selectedRow.Cells["id"].Value}";
                lblEmpName.Text = $"Employee Name: {selectedRow.Cells["name"].Value}";
                //lblTotalSales.Text = $"Total Sales: {selectedRow.Cells["TotalSales"].Value}";
                lblTotalRevenue.Text = $"Total Revenue: {selectedRow.Cells["TotalRevenue"].Value}";
                lblTotalProfit.Text = $"Total Profit: {selectedRow.Cells["TotalProfit"].Value}";

                // Update the chart
                int empID = Convert.ToInt32(selectedRow.Cells["id"].Value);
                UpdateChart(empID);
            }
        }

        // Update the chart for a specific employee
        private void UpdateChart(int empID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(VarStuff.conString))
                {
                    con.Open();

                    string query = "SELECT s.Date, ISNULL(s.total_revenue, 0) AS TotalRevenue, ISNULL(s.total_profit, 0) AS TotalProfit " +
                                   "FROM Sales s " +
                                   "JOIN Employee e ON e.id = s.EmpID " +
                                   "WHERE e.accessLvl = 1 AND s.EmpID = @EmpID " +
                                   "ORDER BY s.Date ASC";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@EmpID", empID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    // Clear previous data on the chart
                    chartPerformance.Series.Clear();
                    chartPerformance.ChartAreas[0].AxisX.Title = "Date";
                    chartPerformance.ChartAreas[0].AxisY.Title = "Amount";
                    chartPerformance.ChartAreas[0].AxisX.Interval = 1;

                    // Create series for Revenue and Profit
                    Series revenueSeries = new Series("Revenue");
                    revenueSeries.ChartType = SeriesChartType.Column;
                    revenueSeries.Color = System.Drawing.Color.Blue;

                    Series profitSeries = new Series("Profit");
                    profitSeries.ChartType = SeriesChartType.Column;
                    profitSeries.Color = System.Drawing.Color.Green;

                    decimal maxRevenue = 0; // To store the maximum revenue for scaling
                    decimal maxProfit = 0;  // To store the maximum profit for scaling

                    // Use a dictionary to track revenue and profit for each date
                    Dictionary<DateTime, (decimal totalRevenue, decimal totalProfit)> dailyData = new Dictionary<DateTime, (decimal totalRevenue, decimal totalProfit)>();

                    while (reader.Read())
                    {
                        DateTime date = reader.IsDBNull(0) ? DateTime.MinValue : reader.GetDateTime(0);
                        var totalRevenue = reader.IsDBNull(1) ? 0 : Convert.ToDecimal(reader[1]);
                        var totalProfit = reader.IsDBNull(2) ? 0 : Convert.ToDecimal(reader[2]);

                        if (date != DateTime.MinValue)
                        {
                            // Add or accumulate revenue and profit for the same date
                            if (dailyData.ContainsKey(date))
                            {
                                dailyData[date] = (dailyData[date].totalRevenue + totalRevenue, dailyData[date].totalProfit + totalProfit);
                            }
                            else
                            {
                                dailyData[date] = (totalRevenue, totalProfit);
                            }

                            // Track the maximum values for scaling
                            if (totalRevenue > maxRevenue)
                            {
                                maxRevenue = totalRevenue;
                            }
                            if (totalProfit > maxProfit)
                            {
                                maxProfit = totalProfit;
                            }
                        }
                    }

                    // Add the data to the chart
                    foreach (var entry in dailyData)
                    {
                        DateTime date = entry.Key;
                        decimal totalRevenue = entry.Value.totalRevenue;
                        decimal totalProfit = entry.Value.totalProfit;

                        // Add data to the series
                        revenueSeries.Points.AddXY(date, totalRevenue);
                        profitSeries.Points.AddXY(date, totalProfit);
                    }

                    // Add the series to the chart
                    chartPerformance.Series.Add(revenueSeries);
                    chartPerformance.Series.Add(profitSeries);

                    // Now calculate the max revenue and profit based on the selected row in DataGridView
                    decimal maxRevenueInGrid = 0;
                    decimal maxProfitInGrid = 0;

                    // Ensure a valid row is selected
                    if (dataGridViewEmployee.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectedRow = dataGridViewEmployee.SelectedRows[0];

                        // Validate if the cells exist and contain valid data
                        if (selectedRow.Cells["TotalRevenue"].Value != DBNull.Value && selectedRow.Cells["TotalProfit"].Value != DBNull.Value)
                        {
                            maxRevenueInGrid = Convert.ToDecimal(selectedRow.Cells["TotalRevenue"].Value);
                            maxProfitInGrid = Convert.ToDecimal(selectedRow.Cells["TotalProfit"].Value);
                        }
                        else
                        {
                            // Handle the case where the values are not available
                            MessageBox.Show("Selected row contains invalid data for revenue or profit.");
                            return; // Exit method if data is invalid
                        }
                    }
                    else
                    {
                        // MessageBox.Show("No row selected in DataGridView.");
                        return; // Exit method if no row is selected
                    }

                    // Calculate the Y-axis max from the selected row values
                    decimal finalMaxValue = Math.Max(maxRevenueInGrid, maxProfitInGrid);

                    // Round the value to the nearest 100
                    decimal roundedMaxValue = Math.Ceiling(finalMaxValue / 100) * 100;

                    // Set the Y-axis scaling based on the rounded value
                    chartPerformance.ChartAreas[0].AxisY.Maximum = (double)roundedMaxValue; // Add buffer
                    chartPerformance.ChartAreas[0].AxisY.Minimum = 0; // Always start from zero

                    // Format the X-axis to display all dates clearly
                    chartPerformance.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Rotate date labels for clarity
                    chartPerformance.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd"; // Ensure proper date formatting

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                // Catch any unexpected exceptions and show a message
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void EmployeePerformance_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Navigate back to the admin form
            this.Hide();
            using (adminForm a1 = new adminForm())
            {
                a1.ShowDialog();
            }
        }
        private void dataGridViewEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= (dataGridViewEmployee.Rows.Count - 2)) // Ensure it's not a header row
            {
                //MessageBox.Show(dataGridViewEmployee.Rows.Count.ToString());
                // Get the clicked row
                DataGridViewRow selectedRow = dataGridViewEmployee.Rows[e.RowIndex];

                // Safely retrieve values with null handling
                int empID = Convert.ToInt32(selectedRow.Cells["id"].Value);
                string empName = selectedRow.Cells["name"].Value?.ToString() ?? "Unknown";
                int totalSales = selectedRow.Cells["TotalSales"].Value == DBNull.Value ? 0 : Convert.ToInt32(selectedRow.Cells["TotalSales"].Value);
                decimal totalRevenue = selectedRow.Cells["TotalRevenue"].Value == DBNull.Value ? 0 : Convert.ToDecimal(selectedRow.Cells["TotalRevenue"].Value);
                decimal totalProfit = selectedRow.Cells["TotalProfit"].Value == DBNull.Value ? 0 : Convert.ToDecimal(selectedRow.Cells["TotalProfit"].Value);

                // Populate text boxes with the retrieved data
                lblEmpID.Text = empID.ToString();
                lblEmpName.Text = empName;
                lblTotalRevenue.Text = "Rs" + totalRevenue.ToString();
                lblTotalProfit.Text = "Rs" + totalProfit.ToString();

                // Update the chart to show detailed revenue/profit per day
                UpdateChart(empID);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminForm af = new adminForm();
            af.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminForm af = new adminForm();
            af.ShowDialog();
        }

        private void chartPerformance_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminStuff.AdminSales af = new AdminSales();
            af.ShowDialog();
        }
    }
}
