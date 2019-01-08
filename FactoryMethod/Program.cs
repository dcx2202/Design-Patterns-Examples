using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            HiringManager DevManager = new DevelopmentManager();
            HiringManager ComManager = new CommunityManager();

            DevManager.TakeInterview();
            ComManager.TakeInterview();

            System.Console.ReadLine();
        }
    }
}
