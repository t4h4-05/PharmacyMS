using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.AdminStuff
{
    public partial class AdminSales : Form
    {
        public AdminSales()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewSales viewSales = new ViewSales();
            viewSales.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmployeePerformance ep = new EmployeePerformance();
            ep.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdminStuff.Sales.SalesDay sales = new Sales.SalesDay();
            sales.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminStuff.Sales.SalesDrug sd = new Sales.SalesDrug();
            sd.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminForm af = new adminForm();
            af.Show();
            this.Hide();
        }
    }
}
