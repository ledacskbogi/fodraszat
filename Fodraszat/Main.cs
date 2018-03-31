using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fodraszat
{
    public class Main : IMain
    {
        private readonly ICustomerManager _getCustomers;
        private readonly IPrintCustomers _printCustomers;

        public Main(ICustomerManager getCustomers, IPrintCustomers printCustomers)
        {
            _getCustomers = getCustomers;
            _printCustomers = printCustomers;
        }

        public void Run()
        {
            var customers = _getCustomers.GetAll();
            _printCustomers.Execute(customers);
        }
    }
}
