//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class kerdoivek
    {
        public kerdoivek()
        {
            this.kerdoiv_kerdes = new HashSet<kerdoiv_kerdes>();
            this.valaszoks = new HashSet<valaszok>();
        }
    
        public int id_kerdoivek { get; set; }
        public Nullable<short> felev { get; set; }
        public Nullable<short> ev { get; set; }
        public Nullable<int> szak { get; set; }
        public Nullable<int> evfolyam { get; set; }
    
        public virtual ICollection<kerdoiv_kerdes> kerdoiv_kerdes { get; set; }
        public virtual ICollection<valaszok> valaszoks { get; set; }
    }
}
