using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopMachine
{
    class Retirado : IState
    {
        BookStateMachine machine;

        public Retirado(BookStateMachine bsm)
        {
            machine = bsm;
        }

        public void cancelar()
        {
            System.Console.WriteLine("Can't cancel now, already retirado.");
        }

        public void disponibilizar()
        {
            System.Console.WriteLine("Can't disponibilizar now, already retirado.");
        }

        public void reservar()
        {
            System.Console.WriteLine("Can't reserve now, already retirado.");
        }

        public void retirar()
        {
            System.Console.WriteLine("Can't retirar now, already retirado.");
        }

        public void vender()
        {
            System.Console.WriteLine("Can't sell now, already retirado.");
        }
    }
}
