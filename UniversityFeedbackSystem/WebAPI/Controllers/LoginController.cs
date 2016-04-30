using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using DMLmethods.DiakDML;

namespace WebAPI.Controllers
{
    
    public class LoginController : ApiController
    {
       [HttpGet]
       public int VerifyNeptunID([FromUri]string id)
       {
           var d = new Diak_Login();
           if(d.VerifyNeptunID(id))
           {
               return 1;
           }
           else
           {
                //TESZT H MEGY E A GITHUBOS SZAR!!
               return 0;
           }
       }
    }
}
