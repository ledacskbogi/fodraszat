using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fodraszat
{
    public class GetPrice : IGetPrice
    {
        public int Execute(string serviceId)
        {
            if (serviceId == ServiceKey.Hajvagas) //Hajvágás
            {
                return 10000;
            }
            else if (serviceId == ServiceKey.Hajfestes) //Hajfestés
            {
                return 16000;
            }
            else if (serviceId == ServiceKey.BalayageMelir) //Balayage melír
            {
                return 20000;
            }
            else if (serviceId == ServiceKey.Hajszaritas) //Hajszárítás
            {
                return 5900;
            }
            else
            {
                throw new Exception("Ismeretlen szolgáltatás típus");
            }
        }
    }
}
