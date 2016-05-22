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
        private int CalculateAverage(List<int> jegyek)
        {
            int atlag = 0;
        
            foreach (var item in jegyek)
            {
                atlag += item;
            }

            return atlag/jegyek.Count;
        }

        private int CalculateAverageW(List<int> jegyek)
        {
            int atlag = 0;

            return atlag;
        }

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
