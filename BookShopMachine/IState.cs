using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopMachine
{
    interface IState
    {
        void retirar();
        void reservar();
        void vender();
        void disponibilizar();
        void cancelar();
    }
}
