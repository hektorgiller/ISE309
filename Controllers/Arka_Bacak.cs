//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication8.Controllers
{
    using System;
    using System.Collections.Generic;
    
    public partial class Arka_Bacak
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Arka_Bacak()
        {
            this.Program = new HashSet<Program>();
        }
    
        public byte ArkaBacakID { get; set; }
        public string HareketAd { get; set; }
        public Nullable<byte> TekrarSayisi { get; set; }
        public Nullable<byte> Kalori { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Program> Program { get; set; }
    }
}
