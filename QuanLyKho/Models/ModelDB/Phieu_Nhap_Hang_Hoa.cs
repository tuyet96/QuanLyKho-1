//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyKho.Models.ModelDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Phieu_Nhap_Hang_Hoa
    {
        public int Hang_Hoa_id { get; set; }
        public int Phieu_Nhap_Id { get; set; }
        public Nullable<decimal> Don_gia { get; set; }
        public string Ten_Nha_Cung_Cap { get; set; }
        public Nullable<int> So_Luong { get; set; }
    
        public virtual Hang_Hoa Hang_Hoa { get; set; }
        public virtual Kho_Chua Kho_Chua { get; set; }
        public virtual Phieu_Nhap Phieu_Nhap { get; set; }
    }
}
