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
    public partial class GetUsedServicesForm : Form
    {
        public GetUsedServicesForm()
        {
            InitializeComponent();

            //Ügyfél combo feltöltés
            var customerManager = new CustomerManager();
            var customers = customerManager.GetAll();
            cmbCustomer.DisplayMember = "Text";
            cmbCustomer.ValueMember = "Value";
            foreach (var customer in customers)
            {
                cmbCustomer.Items.Add(new ComboBoxItem { Text = customer.Name, Value = customer.Id });
            }

        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            var fileUtil = new FileUtil();
            var usedServiceRepository = new UsedServiceRepository(fileUtil);
            var customerManager = new CustomerManager();

            // Példányosítja a getUsedServices objektumot
            var getUsedServices = new GetUsedServices(usedServiceRepository,customerManager);

            // Kiolvassa a combóból a kiválasztott customerId-t
            var customerId = ((ComboBoxItem)cmbCustomer.SelectedItem).Value;

            // Példányosítja a Preview objektumot
            var preview = new Preview(txtUsedServices);

            // Visszadja customerId alapján az igénybevett szolgáltatásokat
            var usedServices = getUsedServices.Execute(customerId);

            // Kitörli az igénybevett szolgáltatásokat
            preview.Clear();

            // Végigmegy a usedServices listán 
            foreach (var usedService in usedServices)
            {
                // Kiírja az igénybevett szolgáltatás azonosítóját és nevét
                preview.WriteLine(usedService.Id + " - " + usedService.Name);
            }
        }
    }
}
