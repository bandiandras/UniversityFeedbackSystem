using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;


namespace DMLmethods.AdminDML
{
    public class DiakSzures
    {
        public Diak DiakInfoByNeptunID(string id)
        {
            var retValue = new Diak();

            var d = new diakok();

            using (var dbcontext = new ORdbEntities())
            {
                d = dbcontext.diakoks.FirstOrDefault(x => x.azonosito == id);
            }

            retValue.azonosito = d.azonosito;
            retValue.evfolyam = d.evfolyam;
            retValue.id_diakok = d.id_diakok;
            retValue.id_szakok = d.id_szakok;
            retValue.kitoltotte1 = d.kitoltotte1;
            retValue.kitoltotte2 = d.kitoltotte2;

            return retValue;
            }

    }
}
