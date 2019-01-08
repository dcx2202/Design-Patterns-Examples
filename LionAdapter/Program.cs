using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LionAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ILion> leoes = new List<ILion>();
            leoes.Add(new AfricanLion());
            leoes.Add(new AsianLion());
            leoes.Add(new WildDogAdapter(new WildDog()));

            foreach(ILion leao in leoes)
                leao.roar();

            System.Console.ReadLine();
        }
    }
}
