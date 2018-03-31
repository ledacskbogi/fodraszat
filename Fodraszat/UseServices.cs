using System;
using System.Collections.Generic;
using System.Linq;

namespace Fodraszat
{
    public class UseServices : IUseServices
    {
        private readonly IUsedServiceRepository _usedServiceRepository;

        /// <summary>
        /// Konstruktor, itt injektáljuk a UsedSericeRepository objektumpéldányát
        /// </summary>
        public UseServices(IUsedServiceRepository usedServiceRepository)
        {
            _usedServiceRepository = usedServiceRepository;
        }

        /// <summary>  
        ///  Igénybevett szolgáltatás tárolása
        /// </summary>
        /// <param name="customerId">Ügyfélazonosító</param>
        public void Execute(string customerId, IList<ServiceModel> services)
        {
            Console.Write(customerId + ": ");
            foreach (var service in services)
            {
                Console.Write(service + ", ");

                _usedServiceRepository.Save(customerId, service);
            }

        }
    }
}
