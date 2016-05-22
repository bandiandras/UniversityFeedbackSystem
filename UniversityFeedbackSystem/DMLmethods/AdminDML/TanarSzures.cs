using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;


namespace DMLmethods.AdminDML
{
    class TanarSzures
    {
        public tanarok TanarInfoByNev(string nev)
        {
            var retValue = new tanarok();

            using (var dbcontext = new ORdbEntities())
            {
                retValue = dbcontext.tanaroks.FirstOrDefault(x => x.nev == nev);

            }

            return retValue;
        }

    }
}
