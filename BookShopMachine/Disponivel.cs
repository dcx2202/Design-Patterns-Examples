using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopMachine
{
    class Disponivel : IState
    {
        BookStateMachine machine;

        public Disponivel(BookStateMachine bsm)
        {
            machine = bsm;
        }

        public void cancelar()
        {
            System.Console.WriteLine("Can't cancel now.");
        }

        public void disponibilizar()
        {
            System.Console.WriteLine("Can't disponibilizar now.");
        }

        public void reservar()
        {
            System.Console.WriteLine("Reserving...");
            machine.setState("Reservado");
        }

        public void retirar()
        {
            System.Console.WriteLine("Retirando...");
            machine.setState("Retirado");
        }

        public void vender()
        {
            System.Console.WriteLine("Can't sell now.");
        }
    }
}
