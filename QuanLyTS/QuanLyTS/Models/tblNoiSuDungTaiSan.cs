//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyTS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblNoiSuDungTaiSan
    {
        public string MaNoiSD { get; set; }
        public string MaTaiSan { get; set; }
        public Nullable<int> SoLuong { get; set; }
    
        public virtual tblNoiSuDung tblNoiSuDung { get; set; }
        public virtual tblTaiSan tblTaiSan { get; set; }
    }
}
