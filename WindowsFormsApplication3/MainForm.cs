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
        // MainForm objektum konstruktora
        public MainForm()
        {
            InitializeComponent();
        }

        private void szolgáltatásIgénybevételeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var usedServiceForm = new UsedServiceForm();
            usedServiceForm.MdiParent = this;
            usedServiceForm.Show();
            MainForm_Resize(null, null);
        }

        private void számlaKészítéseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var createInvoiceForm = new CreateInvoiceForm();
            createInvoiceForm.MdiParent = this;
            createInvoiceForm.Show();
            MainForm_Resize(null, null);
        }

        private void ügyfelekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customersForm = new CustomersForm();
            customersForm.MdiParent = this;
            customersForm.Show();
            MainForm_Resize(null, null);
        }

        private void szolgáltatásokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var servicesForm = new ServicesForm();
            servicesForm.MdiParent = this;
            servicesForm.Show();
            MainForm_Resize(null, null);
        }

        private void igénybevettSzolgáltatásokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var getUsedServicesForm = new GetUsedServicesForm();
            getUsedServicesForm.MdiParent = this;
            getUsedServicesForm.Show();
            MainForm_Resize(null, null);
        }

        // Eseménykezelő eljárás, ami a szülőablak átméretezésekor fut le
        private void MainForm_Resize(object sender, EventArgs e)
        {
            // Végigmegyünk a szülőablak összes nyitott gyerekképernyőjén
            foreach (var childForm in this.MdiChildren)
            {
                var x = (this.Width - childForm.Width) / 2;
                var y = (this.Height - childForm.Height - 64) / 2;
                childForm.Location = new Point(x, y);
            }
        }
    }
}
