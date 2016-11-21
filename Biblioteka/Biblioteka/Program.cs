using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba klient = new Osoba();
            //Czasopismo Piernik = new Czasopismo();
            Autor author = new Autor ("Stefan","Kowalski","Polska");
            //Katalog Katalog1 = new Katalog();
            Pozycja pozycja11 = new Pozycja ("Mielno", 234, "Polgraf", 1994);


        }
    }
}
