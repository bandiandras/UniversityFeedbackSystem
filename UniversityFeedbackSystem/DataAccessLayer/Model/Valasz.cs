using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class Valasz : valaszok
    {
        public Valasz()
        {

        }

        public Valasz(int id_valaszok, int id_kerdoiv, int id_kerdes, int id_kerdes_valaszlehetoseg)
        {
            this.id_valaszok = id_valaszok;
            this.id_kerdoiv = id_kerdoiv;
            this.id_kerdes = id_kerdes;
            this.id_valasz = id_kerdes_valaszlehetoseg;
        }
    }
}
