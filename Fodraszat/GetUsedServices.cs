using System;
using System.Collections.Generic;

namespace Fodraszat
{
    public class GetUsedServices : IGetUsedServices
    {
        private readonly IUsedServiceRepository _usedServiceRepository;

        public GetUsedServices(IUsedServiceRepository usedServiceRepository)
        {
            _usedServiceRepository = usedServiceRepository;
        }

        /// <summary>  
        ///  Igénybevett szolgáltatások lekérdezése  
        /// </summary>
        /// <param name="customerId">Ügyfélazonosító</param>
        /// <returns>Igénybevett szolgáltatások</returns>
        /// <exception cref="System.InvalidOperationException">Nem létező ügyfélazonosító</exception>
        public IList<ServiceModel> Execute(string customerId)
        {

            // TODO HF: Ezt ki kell fejleszeni
            // throw new InvalidOperationException("Nem létező ügyfél azonosító.");


            var usedServices = _usedServiceRepository.GetByCustomerId(customerId);
            return usedServices;
        }
    }
}
