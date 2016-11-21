using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Książka : Pozycja
    {
        private int liczbaStron;
        public Autor autor;
        public Książka(int liczbaStron)
        {
            this.liczbaStron = liczbaStron;
        }
        public Książka()
        {
            liczbaStron = 0;
        }
        public abstract void WypiszInfo();
    }
}
