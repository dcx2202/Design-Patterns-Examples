using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopMachine
{
    class Reservado : IState
    {
        BookStateMachine machine;

        public Reservado(BookStateMachine bsm)
        {
            machine = bsm;
        }

        public void cancelar()
        {
            System.Console.WriteLine("Cancelling...");
            machine.setState("Disponivel");
        }

        public void disponibilizar()
        {
            System.Console.WriteLine("Can't disponibilizar now.");
        }

        public void reservar()
        {
            System.Console.WriteLine("Can't reserve now, already reserved.");
        }

        public void retirar()
        {
            System.Console.WriteLine("Can't retirar now.");
        }

        public void vender()
        {
            System.Console.WriteLine("Selling...");
            machine.setState("Vendido");
        }
    }
}
