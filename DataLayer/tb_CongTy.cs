//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_CongTy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_CongTy()
        {
            this.tb_DonVi = new HashSet<tb_DonVi>();
            this.tb_SYS_User = new HashSet<tb_SYS_User>();
        }
    
        public string MaCty { get; set; }
        public string TenCty { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string DiaChi { get; set; }
        public Nullable<bool> Disable { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_DonVi> tb_DonVi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_SYS_User> tb_SYS_User { get; set; }
    }
}
