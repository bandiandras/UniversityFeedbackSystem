using DataAccessLayer.Helper_objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DMLmethods.DiakDML;
using Newtonsoft.Json;
using System.IO;
using System.Web.Script.Serialization;

namespace WebAPI.Controllers
{
    public class KerdoivController : ApiController
    {
        [Route("api/Kerdoiv/GetKerdoiv/?paramArray=")]
        [HttpGet]
        public List<KerdoivListaElem> GetKerdoiv([FromUri] string paramArray)
        {
            var lParams = paramArray.Split(',');
            
            var ev = Int32.Parse(lParams[0]);
            var felev = Int32.Parse(lParams[1]);
            var neptunId = lParams[2];
            var kerdoivDML = new KerdoivDML();

            var kerdoiv = kerdoivDML.GetKerdoiv(ev, felev, neptunId);
            return kerdoiv;
        }

        [Route("api/Kerdoiv/PostKerdoiv")]
        [HttpPost]
        public void PostKerdoiv([FromBody] object kerdoiv)
        {
            var serializer = new JavaScriptSerializer();
            var adat = serializer.Deserialize<dynamic>(kerdoiv.ToString());

            var valaszok = new ValaszLista();

            valaszok.neptunId = adat[0]["neptunId"];

            for (int i = 1; i < adat.Length; ++i)
            {
                var listaElem = new ValaszListaElem();
                listaElem.question = adat[i]["question"];
                for (int j = 0; j < adat[i]["options"].Length; ++j)
                {
                    OptionsValasz option = new OptionsValasz();
                    option.subject = adat[i]["options"][j]["subject"];
                    option.teacher = adat[i]["options"][j]["teacher"];
                    option.answer = adat[i]["options"][j]["answer"];
                    listaElem.options.Add(option);
                }
                valaszok.valaszok.Add(listaElem);
            }
            var kerdoivDML = new KerdoivDML();
            //kerdoivDML.SaveResults(valaszok, valaszok.neptunId);
        }

    }
}
