using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Helper_objects
{
    public class ValaszListaElem
    {
        public string question;
        public List<OptionsValasz> options = new List<OptionsValasz>();
    }

    public class ValaszLista
    {
        public string neptunId;
        public List<ValaszListaElem> valaszok = new List<ValaszListaElem>();
    }
}
