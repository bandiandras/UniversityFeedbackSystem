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
    
    public partial class Kerdes_valaszlehetoseg
    {
        public Kerdes_valaszlehetoseg()
        {
            this.valaszoks = new HashSet<valaszok>();
        }
    
        public int id_Kerdes_valaszlehetoseg { get; set; }
        public Nullable<int> id_kerdes { get; set; }
        public string valaszlehetoseg { get; set; }
        public Nullable<int> valaszlehetoseg_ertek { get; set; }
    
        public virtual ICollection<valaszok> valaszoks { get; set; }
        public virtual kerdesek kerdesek { get; set; }
    }
}
