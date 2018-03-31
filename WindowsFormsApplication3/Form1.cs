using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Fodraszat;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
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

            //Szolgáltatás combo feltöltés
            var serviceRegister = new ServiceRegister();
            var services = serviceRegister.GetAll();
            cmbSzolgaltatas.DisplayMember = "Text";
            cmbSzolgaltatas.ValueMember = "Value";
            foreach (var service in services)
            {
                cmbSzolgaltatas.Items.Add(new ComboBoxItem { Text = service.Name, Value = service.Id });
            }

        }


        private void cmdSave_Click(object sender, EventArgs e)
        {
            var customerId = ((ComboBoxItem)cmbUgyfel.SelectedItem).Value;
            var serviceId = ((ComboBoxItem)cmbSzolgaltatas.SelectedItem).Value;

            var useServices = new UseServices(new UsedServiceRepository(new FileUtil()));
            useServices.Execute(customerId, new List<ServiceModel>() { new ServiceModel {  Id = serviceId, Name = txtSzolgaltatasNev.Text, TaxRate = 27 } });

            // TODO HF: Egy üzenet ablak ugorjon elő "Sikeres mentés!" üzenettel
        }


        private void cmbSzolgaltatas_SelectedIndexChanged(object sender, EventArgs e)
        {
            var serviceId = ((ComboBoxItem)cmbSzolgaltatas.SelectedItem).Value;

            var serviceRegister = new ServiceRegister();
            var service = serviceRegister.GetById(serviceId);
            txtSzolgaltatasNev.Text = service.Name;
        }

        private void cmbUgyfel_SelectedIndexChanged(object sender, EventArgs e)
        {
            var customerManager = new CustomerManager();
            var id = ((ComboBoxItem)cmbUgyfel.SelectedItem).Value;
            var customer = customerManager.GetById(id);
        }

    }
}
