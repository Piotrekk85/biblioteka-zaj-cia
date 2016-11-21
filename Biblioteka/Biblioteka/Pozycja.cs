using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    abstract class Pozycja
    {
        protected string tytuł;
        protected int id;
        protected string wydawnictwo;
        protected int rokWydania;
        public Pozycja(string tytuł, int id, string wydawnictwo, int rokWydania)
        {
            this.tytuł = tytuł;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
        }
        public Pozycja()
        {
            tytuł = "Biografia";
            id = 1;
            wydawnictwo = "Polgraf";
            rokWydania = DateTime.Today.Year;
        }
        public abstract string WypiszInfo()
        {
            Console.WriteLine("{0},ID {1}, {2},Rok Wydania {3}",tytuł,id,wydawnictwo,rokWydania);
        }
    }
}
