using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Helper_objects
{
    public class TanarStatisztika
    {
        int atlag { get; set; }
        int sulyozottAtlag { get; set; }
        int valaszokSzama { get; set; }

        List<StatisztikaKerdesListaElem> kerdesekEredmenye = new List<StatisztikaKerdesListaElem>();
    }
}
