using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Kerdes : kerdesek
    {
        public Kerdes()
        {

        }

        public Kerdes(int id, string kerdes, string tipus)
        {
            this.id_kerdesek = id;
            this.kerdes = kerdes;
            this.tipus = tipus;
        }
    }
}
