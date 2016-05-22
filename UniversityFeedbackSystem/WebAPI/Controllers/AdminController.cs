using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccessLayer;
using DMLmethods.AdminDML;

namespace WebAPI.Controllers
{
    public class AdminController : ApiController
    {

        [Route("api/admin/diakszures/?paramArray=")]
        [HttpGet]

        public diakok Api_DiakInfoByNeptunID([FromUri] string paramArray)
        {
            var value = new Diak();
            var szures = new DiakSzures();
            value = szures.DiakInfoByNeptunID(paramArray);
            return value;
        }

        [Route("api/admin/tanarszures/?paramArray=")]
        [HttpGet]

        public tanarok Api_TanarInfoByNev([FromUri] string paramArray)
        {
            var value = new Tanar();
            var szures = new TanarSzures();
            value = szures.TanarInfoByNev(paramArray);
            return value;
        }


    }
}
