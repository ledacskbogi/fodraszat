﻿using Fodraszat;
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
    public partial class ServicesForm : Form
    {
        public ServicesForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var preview = new Preview(txtServices);
            var serviceRegister = new ServiceRegister();
            var services = serviceRegister.GetAll();
            preview.Clear();
            foreach (var service in services)
            {
                if (service.Name.ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    preview.WriteLine(service.Id + " - " + service.Name);
                }

            }
        }
    }
}
