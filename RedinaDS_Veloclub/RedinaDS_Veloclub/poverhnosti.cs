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
    
    public partial class poverhnosti
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public poverhnosti()
        {
            this.pokatyshki = new HashSet<pokatyshki>();
        }
    
        public string tip_poverhnosti { get; set; }
        public int cod_poverhnosti { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pokatyshki> pokatyshki { get; set; }
    }
}