using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class TeaMaker
    {
        Dictionary<string, Tea> availableTea = new Dictionary<string, Tea>();

        public Tea makeTea(string preference)
        {
            if (!availableTea.ContainsKey(preference))
                availableTea[preference] = new Tea();
            return availableTea[preference];
        }
    }
}
