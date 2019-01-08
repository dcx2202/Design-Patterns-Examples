using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Editor editor = new Editor();
            editor.type(System.Console.ReadLine());
            editor.type(System.Console.ReadLine());
            editor.saveMemento();
            editor.type(System.Console.ReadLine());
            System.Console.WriteLine("\n\n" + editor.getText());
            editor.restoreMemento();
            System.Console.WriteLine("\n\n" + editor.getText());

            System.Console.ReadLine();
        }
    }
}
