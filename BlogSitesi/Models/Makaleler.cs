//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlogSitesi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Makaleler
    {
        public int MakalelerID { get; set; }
        public string Baslik { get; set; }
        public string icerik { get; set; }
        public Nullable<System.DateTime> EklenmeTarihi { get; set; }
        public Nullable<int> GoruntulenmeSayisi { get; set; }
        public Nullable<System.DateTime> GuncellenmeTarihi { get; set; }
        public Nullable<int> BegenmeSayisi { get; set; }
        public Nullable<int> YazarID { get; set; }
        public Nullable<int> KategoriID { get; set; }
        public Nullable<bool> Aktifmi { get; set; }
    }
}
