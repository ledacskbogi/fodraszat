using System;
using System.Collections.Generic;



namespace Fodraszat
{
    public class PrintCustomers : IPrintCustomers
    {
        public void Execute(IList<CustomerModel> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.BithDate.ToString("yyyy-MM-dd"));
            }
           
        }
    }
}
