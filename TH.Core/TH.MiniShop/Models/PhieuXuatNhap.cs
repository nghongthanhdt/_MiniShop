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
    
    public partial class PhieuXuatNhap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuXuatNhap()
        {
            this.PhieuXuatNhapChiTiet = new HashSet<PhieuXuatNhapChiTiet>();
        }
    
        public int MaPhieuXuatNhap { get; set; }
        public string SoPhieu { get; set; }
        public string SoChungTu { get; set; }
        public string MaHinhThuc { get; set; }
        public string MaLoaiPhieu { get; set; }
        public int MaKhachHang { get; set; }
        public System.DateTime NgayLapPhieu { get; set; }
        public System.DateTime NgayXuatNhap { get; set; }
        public int MaKho { get; set; }
    
        public virtual HinhThucNhapXuat HinhThucNhapXuat { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual Kho Kho { get; set; }
        public virtual LoaiPhieu LoaiPhieu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuXuatNhapChiTiet> PhieuXuatNhapChiTiet { get; set; }
    }
}
