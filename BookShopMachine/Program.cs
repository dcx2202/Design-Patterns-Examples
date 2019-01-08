using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            BookStateMachine machine = new BookStateMachine();
            machine.reservar();
            machine.cancelar();
            machine.reservar();
            machine.vender();
            machine.disponibilizar();
            machine.retirar();
            machine.reservar();

            System.Console.ReadLine();
        }
    }
}
