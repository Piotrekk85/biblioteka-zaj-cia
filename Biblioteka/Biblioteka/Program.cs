﻿using System;
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
            Katalog biblioteka = new Katalog("Dział ogólny");
            biblioteka.DodajPozycje("Henryk", "Sienkiewicz", "Krzyżacy", 23, "Znak", 2010, 220);
            biblioteka.DodajPozycje("Władysław", "Reymont", "Chłopi", 31, "Greg", 2002, 310);
            biblioteka.DodajPozycje(200, "Gazeta Olsztyńska", 123, "Edytor", 2016);
            biblioteka.DodajPozycje("Henryk", "Sienkiewicz", "Krzyżacy", 24, "Znak", 2011, 220);

            biblioteka.WypiszWszystko();

            Console.WriteLine("Wyszukiwanie po tytule");
            biblioteka.WyszukajPoTytule("Krzyżacy");

            Console.WriteLine("Wyszukiwanie po id");
            biblioteka.WyszukajPoId(123);

            Console.ReadKey();

            
            //Pozycja pozycja11 = new Pozycja ("Mielno", 234, "Polgraf", 1994); - nie możemy tworzyć obiektu z klasy abstrakcyjnej


        }
    }
}
