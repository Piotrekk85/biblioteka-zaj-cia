using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    interface IZarzadzanieKatalogiem
    {
        string WyszukajPoTytule();
        int WyszukajPoId();
        void WypiszWszystko();

    }
}
