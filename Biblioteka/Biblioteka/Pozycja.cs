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

                
        //metoda wypisująca informacje, wg polecenia miała być abstrakcyjna, więc "wnętrza"/implementacji tu nie dodajemy
        public abstract void WypiszInfo();

        //metoda pomocnicza do wyszukania po tytule
        public string PobierzTytuł()
        {
            return tytuł;
        }

        //metoda pomocnicza do wyszukania po id
        public int PobierzId()
        {
            return id;
        }
    }
}
