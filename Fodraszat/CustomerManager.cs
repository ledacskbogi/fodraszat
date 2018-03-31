using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fodraszat
{
    public class CustomerManager : ICustomerManager
    {
        public IList<CustomerModel> GetAll()
        {
            var customers = new List<CustomerModel>();

            var customer = new CustomerModel();
            customer.Id = "01";
            customer.Name = "Varga Attilla";
            customer.BithDate = new DateTime(1999, 2, 1);
            customers.Add(customer);

            customer = new CustomerModel();
            customer.Id = "02";
            customer.Name = "Szöllősi Norbi";
            customer.BithDate = new DateTime(1980, 7, 11);
            customers.Add(customer);

            customer = new CustomerModel();
            customer.Id = "03";
            customer.Name = "Lévai Cintia";
            customer.BithDate = new DateTime(1988, 6, 11);
            customers.Add(customer);

            return customers;
        }

        public CustomerModel GetById(string id)
        {

            var customers = GetAll();

            // TODO HF: A foreach helyett Linq-t kell használni
            foreach (var customer in customers)
            {
                if (customer.Id == id)
                {
                    return customer;
                }
            }
            return null; 
        }
    }
}
