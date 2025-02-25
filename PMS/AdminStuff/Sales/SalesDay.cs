using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PMS.AdminStuff.Sales
{
    public partial class SalesDay : Form
    {
        public SalesDay()
        {
            InitializeComponent();
        }

        private void SalesDay_Load(object sender, EventArgs e)
        {
            UpdateDailySalesChart();
        }

        private void UpdateDailySalesChart()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(VarStuff.conString))
                {
                    con.Open();

                    string query = @"
                SELECT 
                    [Date], 
                    SUM(CAST(total_sales AS DECIMAL(10, 2))) AS TotalSales, 
                    SUM(CAST(total_revenue AS DECIMAL(10, 2))) AS TotalRevenue, 
                    SUM(CAST(total_profit AS DECIMAL(10, 2))) AS TotalProfit
                FROM Sales
                GROUP BY [Date]
                ORDER BY [Date] ASC";

                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    chartSales.Series.Clear();
                    chartSales.ChartAreas[0].AxisX.Title = "Date";
                    chartSales.ChartAreas[0].AxisY.Title = "Amount";
                    chartSales.ChartAreas[0].AxisX.Interval = 1;

                    Series salesSeries = new Series("Total Sales");
                    salesSeries.ChartType = SeriesChartType.Column;
                    salesSeries.Color = Color.Blue;

                    Series revenueSeries = new Series("Total Revenue");
                    revenueSeries.ChartType = SeriesChartType.Column;
                    revenueSeries.Color = Color.Green;

                    Series profitSeries = new Series("Total Profit");
                    profitSeries.ChartType = SeriesChartType.Column;
                    profitSeries.Color = Color.Orange;

                    decimal cumulativeSales = 0;
                    decimal cumulativeRevenue = 0;
                    decimal cumilativeProfit = 0;

                    while (reader.Read())
                    {
                        DateTime date = reader.GetDateTime(0);
                        decimal totalSales = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                        decimal totalRevenue = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2);
                        decimal totalProfit = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);

                        // Update cumulative totals
                        cumulativeSales += totalSales;
                        cumulativeRevenue += totalRevenue;
                        cumilativeProfit += totalProfit;

                        // Add points to the series
                        salesSeries.Points.AddXY(date, totalSales);
                        revenueSeries.Points.AddXY(date, totalRevenue);
                        profitSeries.Points.AddXY(date, totalProfit);

                        // Add data labels to the points
                        salesSeries.Points[salesSeries.Points.Count - 1].Label = totalSales.ToString("N0");
                        revenueSeries.Points[revenueSeries.Points.Count - 1].Label = totalRevenue.ToString("N0");
                        profitSeries.Points[profitSeries.Points.Count - 1].Label = totalSales.ToString("N0");
                    }

                    // Add the series to the chart
                    chartSales.Series.Add(salesSeries);
                    chartSales.Series.Add(revenueSeries);
                    chartSales.Series.Add(profitSeries);

                    // Format the chart for better readability
                    chartSales.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Rotate labels
                    chartSales.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd"; // Date format
                    chartSales.ChartAreas[0].AxisY.Minimum = 0; // Start Y-axis at zero


                    //chartSales.Annotations.Add(annotation);
                    label1.Text += cumulativeSales;
                    label2.Text += cumulativeRevenue;
                    label3.Text += cumilativeProfit;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Go back to the previous form
        }

        private void Back_Click(object sender, EventArgs e)
        {
            AdminStuff.AdminSales adminSales = new AdminSales();
            adminSales.Show();
            this.Hide();

        }
    }
}
