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
    
    public partial class LoaiSanh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiSanh()
        {
            this.Sanhs = new HashSet<Sanh>();
        }
    
        public string MaLoaiSanh { get; set; }
        public string TenLoaiSanh { get; set; }
        public Nullable<int> GiaBanToiThieu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sanh> Sanhs { get; set; }
    }
}
