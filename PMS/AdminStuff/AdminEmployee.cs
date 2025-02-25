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
    public partial class AdminEmployee : Form
    {
        public AdminEmployee()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminForm admin = new adminForm();
            admin.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ViewEmp viewEmp = new ViewEmp();
            viewEmp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditEmployee e1 = new EditEmployee();
            e1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditEmployee e1 = new EditEmployee(0);
            e1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminStuff.Employee.FireEmp fireEmp = new Employee.FireEmp();
            fireEmp.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminStuff.Employee.RaiseEmp raiseEmp = new Employee.RaiseEmp();
            raiseEmp.Show();
            this.Hide();
        }
    }
}
