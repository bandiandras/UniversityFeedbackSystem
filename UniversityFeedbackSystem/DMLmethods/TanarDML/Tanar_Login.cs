using DataAccessLayer;
using System.Linq;

namespace DMLmethods.TanarDML
{
    public class Tanar_Login
    {
        public bool VerifyTeacherLogin(string userName, string password)
        {
            using (var dbcontext = new ORdbEntities())
            {
                tanarok tanar = dbcontext.tanaroks.SingleOrDefault(x => x.tanarok_alias == userName && x.jelszo == password);
                if (tanar != null)
                {
                    return true;
                }
                return false;
            }
        }

        public string GetTeacherFunction(string userName)
        {
            using (var dbcontext = new ORdbEntities())
            {
                tanarok tanar = dbcontext.tanaroks.SingleOrDefault(x => x.tanarok_alias == userName);
                return tanar.funkcio;
            }
        } 
    }
}
