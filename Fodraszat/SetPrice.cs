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
            //price.txt nevű fájlba kell kiírni json formátumban
            // a szerializálandó objektum egy List<keyvaluepair<string, int>>, ahol a key a serviceId, a value pedig a price

            // TODO: Át kell írni az egész eljárást hogy Dictionary legyen a List helyett
            var items = new List<KeyValuePair<string, int>>();

            // Beolvas file-ból (akorábban kiírt árak beolvasása file-ból)
            var oldJson = _fileUtil.ReadAllText(dataFilePath);

            // Deszerializál
            if (!string.IsNullOrEmpty(oldJson))
            {
                items = JsonConvert.DeserializeObject<List<KeyValuePair<string, int>>>(oldJson);
            }

            // Amennyiben a régiek között nincsen, hozzáadja az új elemet
            var foundItems = items.Where(x => x.Key == serviceId).ToList(); // TODO: Ez is át lesz írva
            if (foundItems.Count == 1)
            {
                // Van találat tehát felülírjuk a régi árat
                
                // TODO Befejezni, Bogikám!

            }
            else if (foundItems.Count == 0)
            {
                // Nincs találat tehát hozzáadjuk az új elemet
                items.Add(new KeyValuePair<string, int>(serviceId, price));
            }
            else
            {
                throw new Exception("Sérült az adatfile!");
            }

            // Szerializál (abban már benne vannak az új ár és a meglévő árak is együttesen)
            var newJson = JsonConvert.SerializeObject(items);

            // Kiírja file-ba újra (felülírja)
            _fileUtil.WriteAllText(dataFilePath, newJson);
        }
    }
}
