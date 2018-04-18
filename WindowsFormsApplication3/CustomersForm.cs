using Fodraszat;
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
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            var customerManager = new CustomerManager();
            var customers = customerManager.GetAll();
            var preview = new Preview(txtCustomers);
            preview.Clear();
            foreach (var customer in customers)
            {
                if (customer.Name.ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    preview.WriteLine(customer.Id + " - " + customer.Name);
                }

            }

        }
    }
}
