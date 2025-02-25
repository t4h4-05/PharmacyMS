using Microsoft.Data.SqlClient;
using PMS.AdminStuff;
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
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
            label1.Text = "Welcome " + VarStuff.name;
        }

        private void AddDrugs_Click(object sender, EventArgs e)
        {
            AdminStuff.AdminDrugs Ad = new AdminStuff.AdminDrugs();
            Ad.Show();
            this.Hide();
        }

        private void adminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Application.Exit();
        }

        private void addStock_Click(object sender, EventArgs e)
        {
            AdminStuff.AddStock As = new AdminStuff.AddStock();
            As.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminStuff.ViewDrugs Av = new AdminStuff.ViewDrugs();
            Av.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AdminStuff.EditDrugs Ae = new AdminStuff.EditDrugs();
            Ae.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AdminStuff.EditEmployee Ee = new AdminStuff.EditEmployee();
            Ee.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdminStuff.EmployeePerformance Ep = new AdminStuff.EmployeePerformance();
            Ep.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            AdminStuff.ViewSales Avs = new AdminStuff.ViewSales();
            Avs.Show();
            this.Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void adminForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminSales adminSales = new AdminSales();
            adminSales.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminEmployee adminEmployee = new AdminEmployee();
            adminEmployee.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
