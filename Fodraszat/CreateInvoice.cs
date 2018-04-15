using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fodraszat
{
    public class CreateInvoice : ICreateInvoice
    {
        ICustomerManager _getCustomers;
        IGetUsedServices _getUsedServices;
        IGetPrice _getPrice;
        IPreview _preview;

        
        public CreateInvoice(ICustomerManager getCustomers, IGetUsedServices getUsedServices, IGetPrice getPrice, IPreview preview)
        {
            _getCustomers = getCustomers;
            _getUsedServices = getUsedServices;
            _getPrice = getPrice;
            _preview = preview;
        }

        /// <summary>  
        ///  Számla elkészítése  
        /// </summary>
        /// <param name="customerId">Ügyfélazonosító</param>
        public void Execute(string customerId)
        {

            var customers = _getCustomers.GetAll();
            var foundCustomer = new CustomerModel();

            // Linq lambda expression-nel
            foundCustomer = customers.Where(x => x.Id == customerId).ToList().First();

            // Igénybevett szolgáltatások lekérdezése
            var usedServices = _getUsedServices.Execute(customerId);

            _preview.Clear();
            Console.WriteLine("LKB Hajvágószalon                              " + foundCustomer.Name);
            _preview.WriteLine("LKB Hajvágószalon                              " + foundCustomer.Name);
            Console.WriteLine("------------------------------------------------------------");
            _preview.WriteLine("------------------------------------------------------------");
            foreach (var usedService in usedServices)
            {
                var price = _getPrice.Execute(usedService.Id);
                Console.WriteLine(usedService.Name + "                                          " + price);
                _preview.WriteLine(usedService.Name + "                                          " + price);
            }
        }


    }
}
