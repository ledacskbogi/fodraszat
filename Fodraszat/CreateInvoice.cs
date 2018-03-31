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

        
        public CreateInvoice(ICustomerManager getCustomers, IGetUsedServices getUsedServices, IGetPrice getPrice)
        {
            _getCustomers = getCustomers;
            _getUsedServices = getUsedServices;
            _getPrice = getPrice;
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

            Console.WriteLine("LKB Hajvágószalon                              " + foundCustomer.Name);
            Console.WriteLine("------------------------------------------------------------");
            foreach (var usedService in usedServices)
            {
                var price = _getPrice.Execute(usedService.Id);
                Console.WriteLine(usedService + "                                          " + price);
            }
        }


    }
}
