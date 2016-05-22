using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;


namespace DMLmethods.AdminDML
{
    class DiakSzures
    {
        public diakok DiakInfoByNeptunID(string id)
        {
            var retValue = new diakok();

            using (var dbcontext = new ORdbEntities())
            {
                retValue = dbcontext.diakoks.FirstOrDefault(x => x.azonosito == id);

            }

            return retValue;
            }

    }
}
