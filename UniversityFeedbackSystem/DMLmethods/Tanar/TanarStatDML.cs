using DataAccessLayer;
using DataAccessLayer.Helper_objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMLmethods.Tanar
{
    public class TanarStatDML
    {
        public List<TanarStatisztika> GetStatisztika(int tanev,  int felev, string szak, string tantargy)
        {
            var retList = new List<TanarStatisztika>();
            
            using(var dbContext = new ORdbEntities())
            {

            }


            return retList;
        }
    }
}
