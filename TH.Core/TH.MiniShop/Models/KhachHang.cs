//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TH.MiniShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            this.PhieuXuatNhap = new HashSet<PhieuXuatNhap>();
        }
    
        public int MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public bool LaKhachHang { get; set; }
        public bool LaNhaCungCap { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuXuatNhap> PhieuXuatNhap { get; set; }
    }
}
