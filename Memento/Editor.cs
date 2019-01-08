using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Editor
    {
        EditorMemento em;
        string text;

        public Editor()
        {
            text = "";
        }

        public void type(string s)
        {
            text += "\n" + s;
        }

        public void saveMemento()
        {
            em = new EditorMemento(text);
        }

        public void restoreMemento()
        {
            text = em.getMemento();
        }

        public string getText()
        {
            return text;
        }
    }
}
