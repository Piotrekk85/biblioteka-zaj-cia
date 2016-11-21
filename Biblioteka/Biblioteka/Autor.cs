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
        public Autor(string imie,string nazwisko,string narodowosc)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.narodowosc = narodowosc;
        }
        public Autor(string imie,string nazwisko)
        {
            imie = "Stefan";
            nazwisko = "Żeromski";
            narodowosc = "Polska";
        }
    }
}
