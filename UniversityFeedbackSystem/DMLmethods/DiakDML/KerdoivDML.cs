using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Helper_objects;

namespace DMLmethods.DiakDML
{
    public class KerdoivDML
    {
        //Hibakezeles!!!!
        
        
        /// <summary>
        ///
        /// </summary>
        /// <param name="ev"></param>
        /// <param name="felev"></param>
        /// <param name="idSzak"></param>
        /// <returns></returns>
        public List<KerdoivListaElem> GetKerdoiv(int ev, int felev, int idSzak)
        {
            using (var dbcontext = new ORdbEntities())
            {
                var kerdoiv = new List<KerdoivListaElem>();
                try
                {
                    //megkeressuk a megfelelo kerdoivet
                    var lKerdoiv = dbcontext.kerdoiveks.SingleOrDefault(x => x.ev == ev && x.felev == felev);
                    //a kerdoivhez tartozo kerdesek
                    var kerdoivKerdesek = dbcontext.kerdoiv_kerdes
                                          .Where(x => x.id_kerdes == lKerdoiv.id_kerdoivek)
                                          .Select(x => new { x.id_kerdes, x.id_kerdoiv, x.id_kerdoiv_kerdes });
                    //minden kerdeshez megkeressuk a kerdes szoveget es a valaszokat
                    foreach (var k in kerdoivKerdesek)
                    {
                        //uj listaelem
                        KerdoivListaElem kl = new KerdoivListaElem();
                        //megkeresem a kerdes szoveget
                        var lKerdes = dbcontext.kerdeseks.SingleOrDefault(x => x.id_kerdesek == k.id_kerdes);
                        kl.question = lKerdes.kerdes;

                        var lOption = new Options();

                        //a kerdeshez tartozo x idket le kell kerjem
                        var lX = dbcontext.kerdes_x
                                    .Where(x => x.id_kerdes == k.id_kerdes)
                                    .Select(x => new { x.id_x });

                        //minden x_id eseten feltoltjuk az Options tipusu listat
                        foreach (var kapcs in lX)
                        {
                            var lTanarNev = dbcontext.x
                                                .Where(x => x.id_x == kapcs.id_x)
                                                .Select(x => new { x.tanarok.nev })
                                                .SingleOrDefault();

                            var lTantargyNev = dbcontext.x
                                                    .Where(x => x.id_x == kapcs.id_x)
                                                    .Select(x => new { x.tantargyak.nev })
                                                    .SingleOrDefault();

                            lOption.teacher = lTanarNev.nev;
                            lOption.subject = lTantargyNev.nev;

                            kl.options.Add(lOption);
                        }

                        var lValaszok = dbcontext.valaszoks
                                     .Where(x => x.id_kerdes == k.id_kerdes)
                                     .Select(x => new { x.id_valaszok, x.id_kerdoiv, x.id_kerdes, x.id_valasz });
                        foreach (var v in lValaszok)
                        {
                            //a megfelelo sorok lekerese a kerdes valaszlehetoeg tablabol
                            var lKerdesValaszlehetoseg = dbcontext.Kerdes_valaszlehetoseg
                                                            .Where(x => x.id_kerdes == k.id_kerdes)
                                                            .Select(x => new { x.id_Kerdes_valaszlehetoseg, x.id_kerdes, x.valaszlehetoseg, x.valaszlehetoseg_ertek });
                            foreach (var kv in lKerdesValaszlehetoseg)
                            {
                                kl.answers.Add(kv.valaszlehetoseg);
                            }
                        }
                        kerdoiv.Add(kl);
                    }

                }
                catch (Exception ex)
                {
                    
                    //throw;
                }             
                return kerdoiv;
            }
        }

        public void SaveResults(List<ValaszListaElem> valaszok)
        {
            foreach(var elem in valaszok)
            {
                //elmentem a kerdest

            }
        }
    }
}