using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fodraszat
{
    public interface IUseServices
    {
       void Execute(string customer, IList<ServiceModel> services);
    }
}
