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

        //konstruktor parametryczny (warto go uzupełnić by ustawiał autora, jako nowy obiekt)
        public Książka(string imie, string nazwisko,string tytul, int id, string wydawnictwo, int rokWydania,int liczbaStron)
            :base(tytul,id,wydawnictwo,rokWydania)
        {
            this.liczbaStron = liczbaStron;
            autor = new Autor(imie,nazwisko);
        }
        
        //konstruktor domyślny (warto dodać tworzenie pola autor jako obiektu Autor)
        public Książka()
        {
            autor = new Autor();
        }

                
        //w klasie potomnej musimy przesłonić metodę abstrakcyjną i dodać implementację
        public override void WypiszInfo()
        {
            Console.WriteLine("Tytuł: {0}",tytuł);
            Console.WriteLine("Autor: {0}",autor.PobierzAutora());
            Console.WriteLine("Nr katalogowy: {0}", id);
            Console.WriteLine("Wydawnictwo: {0}", wydawnictwo);
            Console.WriteLine("Rok wydaniwa: {0}", rokWydania);
            Console.WriteLine("Liczba stron: {0}", liczbaStron);
        }
    }
}
