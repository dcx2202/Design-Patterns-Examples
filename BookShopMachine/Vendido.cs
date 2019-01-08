using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopMachine
{
    class Vendido : IState
    {
        BookStateMachine machine;

        public Vendido(BookStateMachine bsm)
        {
            machine = bsm;
        }

        public void cancelar()
        {
            System.Console.WriteLine("Can't cancel now, already sold.");
        }

        public void disponibilizar()
        {
            System.Console.WriteLine("Disponibilizando...");
            machine.setState("Disponivel");
        }

        public void reservar()
        {
            System.Console.WriteLine("Can't reserve now.");
        }

        public void retirar()
        {
            System.Console.WriteLine("Retirando...");
            machine.setState("Retirado");
        }

        public void vender()
        {
            System.Console.WriteLine("Can't sell now, already sold.");
        }
    }
}
