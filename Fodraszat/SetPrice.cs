using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fodraszat
{
    public class SetPrice : ISetPrice
    {
        private const string dataFilePath = "~\\..\\..\\..\\..\\FodraszatTest\\TestData\\price.txt";
        private readonly IFileUtil _fileUtil;

        public SetPrice(IFileUtil fileUtil)
        {
            _fileUtil = fileUtil;
        }

        // Ez van a Save helyett, ez hajtja végre a file-ba való írást
        public void Execute(string serviceId, int price)
        {
            var items = new Dictionary<string, int>();

            // Beolvas file-ból (akorábban kiírt árak beolvasása file-ból)
            var oldJson = _fileUtil.ReadAllText(dataFilePath);

            // Deszerializál
            if (!string.IsNullOrEmpty(oldJson))
            {
                try
                {
                    items = JsonConvert.DeserializeObject<Dictionary<string, int>>(oldJson);
                }
                catch (Exception)
                {
                    throw new Exception("Sérült az adatfile!");
                }
            }

            // Amennyiben a régiek között nincsen, hozzáadja az új elemet
            if (items.ContainsKey(serviceId))
            {
                items[serviceId] = price;
            }
            else
            {
                // Nincs találat tehát hozzáadjuk az új elemet
                items.Add(serviceId, price);
            }

            // Szerializál (abban már benne vannak az új ár és a meglévő árak is együttesen)
            var newJson = JsonConvert.SerializeObject(items);

            // Kiírja file-ba újra (felülírja)
            _fileUtil.WriteAllText(dataFilePath, newJson);
        }
    }
}
