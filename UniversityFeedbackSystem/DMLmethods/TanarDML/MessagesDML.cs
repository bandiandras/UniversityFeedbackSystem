using DataAccessLayer;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DMLmethods.Tanar
{


    public class MessagesDML
    {
        /// <summary>
        ///  uzenet elmentese a tablaba
        /// </summary>
        /// <param name="_tanarId"></param>
        /// <param name="_subject"></param>
        /// <param name="_message"></param>
        /// <param name="_dateTime"></param>
        public void SaveMessages(int _tanarId, string _subject, string _message, DateTime _dateTime ) {
            using (var dbcontext = new ORdbEntities()) {

                Message m = new Message();
                m.tanarId = _tanarId;
                m.subject = _subject;
                m.message1 = _message;
                m.dateTime = _dateTime;

                //uzenet hozzaadasa 
                dbcontext.Messages.Add(m);

                //Lementjuk avaltozasokat
                dbcontext.SaveChanges();


            }
        }
    }
}
