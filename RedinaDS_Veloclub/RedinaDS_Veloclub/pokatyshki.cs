//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RedinaDS_Veloclub
{
    using System;
    using System.Collections.Generic;
    
    public partial class pokatyshki
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pokatyshki()
        {
            this.uchastie = new HashSet<uchastie>();
        }
    
        public int cod_pokatyshek { get; set; }
        public string nazvanie { get; set; }
        public Nullable<int> col_vo_km { get; set; }
        public Nullable<System.DateTime> data { get; set; }
        public Nullable<int> dlitelnosti { get; set; }
        public Nullable<double> sred_skorosti { get; set; }
        public Nullable<int> cod_poverhnosti { get; set; }
    
        public virtual poverhnosti poverhnosti { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<uchastie> uchastie { get; set; }
    }
}