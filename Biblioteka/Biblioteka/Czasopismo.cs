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

        //konstruktor parametryczny (lepiej użyc base)
        public Czasopismo (int numer,string tytuł,int id, string wydawnictwo,int rokWydania)
            : base(tytuł, id, wydawnictwo, rokWydania)
        {
            this.numer = numer;
        }
        public Czasopismo()
        {
            numer = 0;
            tytuł = "tytuł";
            id = 0;
            wydawnictwo = "wydawnictwo";
            rokWydania = DateTime.Today.Year;
        }
        
        //trzeba przesłonić metodę i dodać tu implementację
        public override void WypiszInfo()
        {
            Console.WriteLine("Tytuł: {0}", tytuł);
            Console.WriteLine("Numer: {0}", numer);
            Console.WriteLine("Nr katalogowy: {0}", id);
            Console.WriteLine("Wydawnictwo: {0}", wydawnictwo);
            Console.WriteLine("Rok wydaniwa: {0}", rokWydania);
        }
        
    }
}
