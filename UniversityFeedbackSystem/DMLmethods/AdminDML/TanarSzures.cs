using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;


namespace DMLmethods.AdminDML
{
    public class TanarSzures
    {
        public Tanar TanarInfoByNev(string nev)
        {
            var retValue = new Tanar();
            var t = new tanarok();

            using (var dbcontext = new ORdbEntities())
            {
                t = dbcontext.tanaroks.FirstOrDefault(x => x.nev == nev);

            }
            retValue.id_tanszekek = t.id_tanszekek;
            retValue.id_tanarok = t.id_tanarok;
            retValue.nev = t.nev;
            retValue.tanarok_alias = t.tanarok_alias;
            retValue.tanszekek = t.tanszekek;

            return retValue;
        }

    }
}
