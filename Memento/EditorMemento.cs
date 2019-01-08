using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class EditorMemento
    {
        string text;

        public EditorMemento(string s)
        {
            text = s;
        }

        public string getMemento()
        {
            return text;
        }
    }
}
