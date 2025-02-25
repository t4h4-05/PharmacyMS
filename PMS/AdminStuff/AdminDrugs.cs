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
    public partial class AdminDrugs : Form
    {
        public AdminDrugs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminStuff.AddDrugs addDrugs = new AdminStuff.AddDrugs();
            addDrugs.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminStuff.AddStock addStock = new AddStock();
            addStock.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminStuff.ViewDrugs viewDrugs = new AdminStuff.ViewDrugs();
            viewDrugs.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminStuff.Drugs.EditPrice ep = new Drugs.EditPrice();
            ep.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminStuff.EditDrugs editDrugs = new EditDrugs();
            editDrugs.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddDrugs add = new AddDrugs();
            add.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            adminForm af = new adminForm();
            af.Show();
            this.Hide();
        }
    }
}
