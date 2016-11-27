using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Autor:Osoba
    {
        private string narodowosc;

        //konstuktor parametryczny (można odwołać się z pomocą base do konstruktora z klasy wyżej, tak wg dokumentacji jest lepiej)
        public Autor(string imie,string nazwisko,string narodowosc)
            :base(imie,nazwisko)
        {
            this.narodowosc = narodowosc;
        }

        //konstruktor domyslny
        public Autor() { }

       

        //konstruktor z 2 parametrami (bez narodowosci) - uwaga jw
        public Autor(string imie,string nazwisko)
            :base(imie,nazwisko)
        {
            narodowosc = "Polska";
        }

        public string PobierzAutora()
        {
            return imie + " " + nazwisko;
        }
    }
}
