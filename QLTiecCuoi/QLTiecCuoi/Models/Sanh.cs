//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLTiecCuoi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sanh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sanh()
        {
            this.TiecCuois = new HashSet<TiecCuoi>();
        }
    
        public string MaSanh { get; set; }
        public string TenSanh { get; set; }
        public Nullable<int> MaLoaiSanh { get; set; }
        public Nullable<int> SoLuongBanToiThieu { get; set; }
        public Nullable<int> SoLuongBanToiDa { get; set; }
    
        public virtual LoaiSanh LoaiSanh { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TiecCuoi> TiecCuois { get; set; }
    }
}
