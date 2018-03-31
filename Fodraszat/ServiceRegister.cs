using System;
using System.Collections.Generic;

namespace Fodraszat
{
    public class ServiceRegister : IServiceRegister
    {
        public IList<ServiceModel> GetAll()
        {
            var services = new List<ServiceModel>();
            services.Add(new ServiceModel { Id = ServiceKey.Hajvagas, Name = "Hajvágás", TaxRate = 27 });
            services.Add(new ServiceModel { Id = ServiceKey.Hajfestes, Name = "Hajfestés", TaxRate = 27 }); 
            services.Add(new ServiceModel { Id = ServiceKey.Hajszaritas, Name = "Hajszárítás", TaxRate = 27 });
            services.Add(new ServiceModel { Id = ServiceKey.BalayageMelir, Name = "Balayage melír", TaxRate = 27 });
            services.Add(new ServiceModel { Id = ServiceKey.Melir, Name = "Melír", TaxRate = 27 });
            services.Add(new ServiceModel { Id = ServiceKey.Dauer, Name = "Dauer", TaxRate = 27 });
            return services;
        }

        public ServiceModel GetById(string id)
        {
            var services = GetAll();

            // TODO HF: A foreach helyett Linq-t kell használni
            foreach (var service in services)
            {
                if (service.Id == id)
                {
                    return service;
                }
            }
            return null;
        }
    }
}
