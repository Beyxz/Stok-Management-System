//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StokTakip1.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Demirbas_Departman
    {
        public int DemirbasDepartmanId { get; set; }
        public int DemirbasId { get; set; }
        public int ZimmetId { get; set; }
        public Nullable<int> Adet { get; set; }
    
        public virtual Demirbas Demirbas { get; set; }
        public virtual Zimmet Zimmet { get; set; }
    }
}
