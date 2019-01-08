using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LionAdapter
{
    class WildDogAdapter : ILion
    {
        WildDog wilddog;

        public WildDogAdapter(WildDog dog)
        {
            wilddog = dog;
        }

        public void roar()
        {
            wilddog.bark();
        }
    }
}
