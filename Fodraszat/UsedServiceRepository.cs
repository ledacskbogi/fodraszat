using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;


namespace Fodraszat
{
    public class UsedServiceRepository : IUsedServiceRepository
    {
        private const string dataFilePath = "~\\..\\..\\..\\..\\FodraszatTest\\TestData\\data.txt";
        private readonly IFileUtil _fileUtil;

        public UsedServiceRepository(IFileUtil fileUtil)
        {
            _fileUtil = fileUtil;
        }

        public void Save(string customerId, ServiceModel service)
        {
            var items = new List<KeyValuePair<string, ServiceModel>>();

            // Beolvas file-ból
            var oldJson = _fileUtil.ReadAllText(dataFilePath);

            // Deszerializál
            if(!string.IsNullOrEmpty(oldJson))
            {
               items = JsonConvert.DeserializeObject<List<KeyValuePair<string, ServiceModel>>>(oldJson);
            }

            // Hozzáadja az új elemet
            items.Add(new KeyValuePair<string, ServiceModel>(customerId, service));

            // Szerializál
            var newJson = JsonConvert.SerializeObject(items);

            // Kiírja file-ba újra (felülírja)
            _fileUtil.WriteAllText(dataFilePath, newJson);
        }

        public IList<ServiceModel> GetByCustomerId(string customerId)
        {
            var usedServices = new List<ServiceModel>();

            // TODO HF: Implementálni ide a hiányzó programkódot

            return usedServices;
        }
    }
}
