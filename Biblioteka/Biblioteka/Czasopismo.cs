using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Czasopismo : Pozycja
    {
        private int numer;
        public Czasopismo (int numer,string tytuł,int id, string wydawnictwo,int rokWydania)
        {
            this.numer = numer;
            this.tytuł = tytuł;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
        }
        public Czasopismo()
        {
            numer = 0;
            tytuł = "tytuł";
            id = 0;
            wydawnictwo = "wydawnictwo";
            rokWydania = DateTime.Today.Year;
        }
        public void WypiszInfo();
    }
}
