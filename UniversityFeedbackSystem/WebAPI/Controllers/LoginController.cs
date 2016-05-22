using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using DMLmethods.DiakDML;
using DMLmethods.TanarDML;

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
               return 0;
           }
       }

       [HttpPost]
       public string LoginTeacher([FromBody]string userName, [FromBody]string passWord)
       {
           var tanar = new Tanar_Login();
           if (tanar.VerifyTeacherLogin(userName, passWord))
           {
               return tanar.GetTeacherFunction(userName);
           }
           return "error";
       }

    }
}
