using DataAccessLayer.Helper_objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DMLmethods.DiakDML;

namespace WebAPI.Controllers
{
    public class KerdoivController : ApiController
    {
        [Route("api/Kerdoiv/GetKerdoiv/?paramArray=")]
        [HttpGet]
        public List<KerdoivLista> GetKerdoiv([FromUri] string paramArray)
        {
            var lParams = paramArray.Split(',');
            var ev = Int32.Parse(lParams[0]);
            var felev = Int32.Parse(lParams[1]);
            var idSzak = Int32.Parse(lParams[2]);
            var kerdoivDML = new KerdoivDML();
            return kerdoivDML.GetKerdoiv(ev, felev, idSzak);
        }

    }
}
