using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Data.SqlClient;

namespace PMS.AdminStuff.Sales
{
    public partial class SalesDrug : Form
    {
        public SalesDrug()
        {
            InitializeComponent();
        }

        private void SalesDrug_Load(object sender, EventArgs e)
        {
            LoadDrugDataWithSales();
        }

        private void LoadDrugDataWithSales()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(VarStuff.conString))
                {
                    con.Open();

                    string query = @"
                    SELECT DISTINCT 
                        d.Reg AS [ID],
                        d.Name AS [Drug Name],
                        d.G_Name AS [Generic Name],
                        d.Type AS [Type],
                        d.IPrice AS [Internal Price],
                        d.CPrice AS [Consumer Price],
                        d.QtyIS AS [Quantity in Stock],
                        d.ttlSold AS [Total Sold]
                    FROM Drugs d
                    JOIN Sales s ON s.items LIKE '%' + d.Name + '%'
                    WHERE s.items IS NOT NULL";

                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewDrugs.DataSource = dt;

                    dataGridViewDrugs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewDrugs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridViewDrugs.MultiSelect = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading drug data: {ex.Message}");
            }
        }

        private void dataGridViewDrugs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string selectedDrugName = dataGridViewDrugs.Rows[e.RowIndex].Cells["Drug Name"].Value.ToString();

                LoadDrugSalesChart(selectedDrugName);
            }
        }

        private void LoadDrugSalesChart(string drugName)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(VarStuff.conString))
                {
                    con.Open();

                    string query = @"
            SELECT 
                s.Date, 
                SUM(TRY_CAST(SUBSTRING(
                    i.value, 
                    CHARINDEX('Qty:', i.value) + 5, 
                    CHARINDEX(',', i.value, CHARINDEX('Qty:', i.value)) - CHARINDEX('Qty:', i.value) - 5
                ) AS INT)) AS QuantitySold,
                SUM(s.total_revenue) AS TotalRevenue
            FROM Sales s
            CROSS APPLY STRING_SPLIT(s.items, CHAR(10)) AS i
            WHERE i.value LIKE '%' + @DrugName + '%'
            GROUP BY s.Date
            HAVING 
                SUM(TRY_CAST(SUBSTRING(
                    i.value, 
                    CHARINDEX('Qty:', i.value) + 5, 
                    CHARINDEX(',', i.value, CHARINDEX('Qty:', i.value)) - CHARINDEX('Qty:', i.value) - 5
                ) AS INT)) > 0 OR 
                SUM(s.total_revenue) > 0
            ORDER BY s.Date ASC";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@DrugName", drugName);

                    SqlDataReader reader = cmd.ExecuteReader();

                    chartDrugsSold.Series.Clear();
                    chartDrugsSold.ChartAreas[0].AxisX.Title = "Date";
                    chartDrugsSold.ChartAreas[0].AxisY.Title = "Amount";
                    chartDrugsSold.ChartAreas[0].AxisX.Interval = 1;

                    Series quantitySeries = new Series("Quantity Sold")
                    {
                        ChartType = SeriesChartType.Column,
                        Color = System.Drawing.Color.Blue
                    };

                    Series revenueSeries = new Series("Revenue")
                    {
                        ChartType = SeriesChartType.Column,
                        Color = System.Drawing.Color.Green
                    };

                    decimal maxQuantity = 0;
                    decimal maxRevenue = 0;

                    Dictionary<DateTime, (decimal quantitySold, decimal totalRevenue)> salesData = new Dictionary<DateTime, (decimal, decimal)>();

                    while (reader.Read())
                    {
                        DateTime date = reader.GetDateTime(0);
                        decimal quantitySold = reader.IsDBNull(1) ? 0 : Convert.ToDecimal(reader[1]);
                        decimal totalRevenue = reader.IsDBNull(2) ? 0 : Convert.ToDecimal(reader[2]);

                        salesData[date] = (quantitySold, totalRevenue);

                        if (quantitySold > maxQuantity)
                        {
                            maxQuantity = quantitySold;
                        }
                        if (totalRevenue > maxRevenue)
                        {
                            maxRevenue = totalRevenue;
                        }
                    }

                    foreach (var entry in salesData)
                    {
                        DateTime date = entry.Key;
                        decimal quantitySold = entry.Value.quantitySold;
                        decimal totalRevenue = entry.Value.totalRevenue;

                        quantitySeries.Points.AddXY(date, quantitySold);
                        revenueSeries.Points.AddXY(date, totalRevenue);
                    }

                    chartDrugsSold.Series.Add(quantitySeries);
                    chartDrugsSold.Series.Add(revenueSeries);

                    decimal finalMaxValue = Math.Max(maxQuantity, maxRevenue);
                    decimal roundedMaxValue = Math.Ceiling(finalMaxValue / 100) * 100; // Round to the nearest 100
                    chartDrugsSold.ChartAreas[0].AxisY.Maximum = (double)roundedMaxValue;
                    chartDrugsSold.ChartAreas[0].AxisY.Minimum = 0;

                    chartDrugsSold.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Rotate labels
                    chartDrugsSold.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd"; // Format dates
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading chart data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Back_Click(object sender, EventArgs e)
        {
            AdminSales adminSales = new AdminSales();
            adminSales.Show();
            this.Hide();
        }
    }
}