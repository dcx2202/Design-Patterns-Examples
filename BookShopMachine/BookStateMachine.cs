using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopMachine
{
    class BookStateMachine
    {
        Dictionary<string, IState> states = new Dictionary<string, IState>();
        IState current;

        public BookStateMachine()
        {
            states.Add("Disponivel", new Disponivel(this));
            states.Add("Reservado", new Reservado(this));
            states.Add("Vendido", new Vendido(this));
            states.Add("Retirado", new Retirado(this));

            current = states["Disponivel"];
        }

        public void setState(string state)
        {
            current = states[state];
        }

        public void retirar()
        {
            current.retirar();
        }

        public void reservar()
        {
            current.reservar();
        }

        public void vender()
        {
            current.vender();
        }

        public void disponibilizar()
        {
            current.disponibilizar();
        }

        public void cancelar()
        {
            current.cancelar();
        }
    }
}
