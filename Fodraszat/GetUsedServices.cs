using System;
using System.Collections.Generic;

namespace Fodraszat
{
    public class GetUsedServices : IGetUsedServices
    {
        private readonly IUsedServiceRepository _usedServiceRepository;
        private readonly ICustomerManager _customerManager;

        /// <summary>
        /// Ez itt a konstruktor
        /// </summary>
        public GetUsedServices(IUsedServiceRepository usedServiceRepository, ICustomerManager customerManager)
        {
            _usedServiceRepository = usedServiceRepository;
            _customerManager = customerManager;

        }

        /// <summary>  
        ///  Igénybevett szolgáltatások lekérdezése  
        /// </summary>
        /// <param name="customerId">Ügyfélazonosító</param>
        /// <returns>Igénybevett szolgáltatások</returns>
        /// <exception cref="System.InvalidOperationException">Nem létező ügyfélazonosító</exception>
        public IList<ServiceModel> Execute(string customerId)
        {
          var customers = _customerManager.GetAll();

            var isMatch = false;
            foreach (var customer in customers)
            {
                if (customer.Id == customerId)
                {
                    isMatch = true;
                }
            }
            if (isMatch == false)
            {
                throw new InvalidOperationException("Nem létező ügyfél azonosító.");
            }

            var usedServices = _usedServiceRepository.GetByCustomerId(customerId);
            return usedServices;
        }
    }
}
