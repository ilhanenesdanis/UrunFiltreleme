//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ÜrünFiltreleme.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ürünler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ürünler()
        {
            this.ÜrünOzelllik = new HashSet<ÜrünOzelllik>();
        }
    
        public int Id { get; set; }
        public string ÜrünAdı { get; set; }
        public Nullable<int> Stok { get; set; }
        public string Açıklama { get; set; }
        public Nullable<int> Fİyat { get; set; }
        public Nullable<int> KategoriId { get; set; }
    
        public virtual Kategoriler Kategoriler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ÜrünOzelllik> ÜrünOzelllik { get; set; }
    }
}
