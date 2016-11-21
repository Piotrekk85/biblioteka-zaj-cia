using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Katalog : IZarzadzanieKatalogiem
    {
        private string dzialTematyczny;
        public List<Pozycja> listaPozycji;
        public Katalog(string dzialTematyczny)
        {
            this.dzialTematyczny = dzialTematyczny;
        }
        public Katalog()
        {
            dzialTematyczny = "Niezdefiniowany";
        }
        public void DodajPozycje()
        {
            List<Pozycja>.listaPozycji.Add();
        }
        string WyszukajPoTytule();
        int WyszukajPoId();
        void WypiszWszystko();
    }
}
