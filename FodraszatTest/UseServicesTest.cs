using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fodraszat;
using System.Collections.Generic;

namespace FodraszatTest
{
    [TestClass]
    public class UseServicesTest
    {
        [TestMethod]
        public void ExecuteTest()
        {
            //Arrange
            var useServices = new UseServices(new UsedServiceRepository(new FileUtil()));
            var customer = "Bukó Attila";
            var services = new List<ServiceModel>();
            services.Add(new ServiceModel { Id = ServiceKey.Hajfestes, Name = "Hajfestés", TaxRate = 27 });
            services.Add(new ServiceModel { Id = ServiceKey.Hajvagas, Name = "Hajvágás", TaxRate = 27 });
            services.Add(new ServiceModel { Id = ServiceKey.BalayageMelir, Name = "Balayage Melír", TaxRate = 27 });

            //Act
            useServices.Execute(customer,services);


        }
    }
}
