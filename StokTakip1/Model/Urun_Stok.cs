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
    
    public partial class Urun_Stok
    {
        public int StokId { get; set; }
        public int UrunId { get; set; }
        public int Stok { get; set; }
    
        public virtual Urun Urun { get; set; }
    }
}
