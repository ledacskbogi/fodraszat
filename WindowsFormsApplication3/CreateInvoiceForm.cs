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
    public partial class CreateInvoiceForm : Form
    {
        public CreateInvoiceForm()
        {
            InitializeComponent();

            //Ügyfél combo feltöltés
            var customerManager = new CustomerManager();
            var customers = customerManager.GetAll();
            cmbUgyfel.DisplayMember = "Text";
            cmbUgyfel.ValueMember = "Value";
            foreach (var customer in customers)
            {
                cmbUgyfel.Items.Add(new ComboBoxItem { Text = customer.Name, Value = customer.Id });
            }
        }


        private void cmdCreateInvoice_Click(object sender, EventArgs e)
        {
            var customerManager = new CustomerManager();
            var fileUtil = new FileUtil();
            var usedServiceRepository = new UsedServiceRepository(fileUtil);
            var getUsedServices = new GetUsedServices(usedServiceRepository, customerManager);
            var getPrice = new GetPrice();
            var preview = new Preview(txtInvoice);
            var createInvoice = new CreateInvoice(customerManager, getUsedServices, getPrice, preview);
            var customerId = ((ComboBoxItem)cmbUgyfel.SelectedItem).Value;


            createInvoice.Execute(customerId);

        }

        private void txtInvoice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
