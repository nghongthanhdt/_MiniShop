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
    
    public partial class PhieuXuatNhapChiTiet
    {
        public int ID { get; set; }
        public int MaPhieuXuatNhap { get; set; }
        public int MaSanPham { get; set; }
    
        public virtual SanPham SanPham { get; set; }
        public virtual PhieuXuatNhap PhieuXuatNhap { get; set; }
    }
}
