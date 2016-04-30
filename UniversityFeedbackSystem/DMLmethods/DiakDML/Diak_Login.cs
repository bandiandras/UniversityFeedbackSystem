using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMLmethods.DiakDML
{
    public class Diak_Login
    {
        /// <summary>
        /// Ellenorzi, hogy a kapott neptun koddal letezik e diak
        /// </summary>
        /// <param name="id"></param>
        /// <returns>1, ha letezik diak, 0 ha nem</returns>
        public bool VerifyNeptunID(string id)
        {
            using(var dbcontext = new ORdbEntities())
            {
                Diak diak = (Diak)dbcontext.diakoks.SingleOrDefault(x => x.azonosito == id);
                if (diak != null && (diak.kitoltotte1 == 1))
                {     
                    return true;
                }
                return false;
            }

        }
    }
}
