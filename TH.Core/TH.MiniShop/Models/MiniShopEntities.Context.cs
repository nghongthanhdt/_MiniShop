﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MiniShopEntities : DbContext
    {
        public MiniShopEntities()
            : base("name=MiniShopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PhieuXuatNhap> PhieuXuatNhap { get; set; }
        public virtual DbSet<PhieuXuatNhapChiTiet> PhieuXuatNhapChiTiet { get; set; }
        public virtual DbSet<XuatNhapTonNgay> XuatNhapTonNgay { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }
        public virtual DbSet<DonViTinh> DonViTinh { get; set; }
        public virtual DbSet<LoaiSanPham> LoaiSanPham { get; set; }
        public virtual DbSet<HinhThucNhapXuat> HinhThucNhapXuat { get; set; }
        public virtual DbSet<Kho> Kho { get; set; }
        public virtual DbSet<LoaiPhieu> LoaiPhieu { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
    }
}
