using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Helper_objects
{
    public class KerdoivListaElem
    {
        public string question;
        public List<Options> options = new List<Options>();
        public List<string> answers = new List<string>();
    }
}
