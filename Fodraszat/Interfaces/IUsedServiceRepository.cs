using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fodraszat
{
    public interface IUsedServiceRepository
    {
        void Save(string customerId, ServiceModel service);

        IList<ServiceModel> GetByCustomerId(string customerId);
    }
}
