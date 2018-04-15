using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void szolgáltatásIgénybevételeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var usedServiceForm = new UsedServiceForm();
            usedServiceForm.MdiParent = this;
            usedServiceForm.Show();
        }

        private void számlaKészítéseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var createInvoiceForm = new CreateInvoiceForm();
            createInvoiceForm.MdiParent = this;
            createInvoiceForm.Show();
        }

        private void ügyfelekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customersForm = new CustomersForm();
            customersForm.MdiParent = this;
            customersForm.Show();
        }

        private void szolgáltatásokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var servicesForm = new ServicesForm();
            servicesForm.MdiParent = this;
            servicesForm.Show();
        }
    }
}
