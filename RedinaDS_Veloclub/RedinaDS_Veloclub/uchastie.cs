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
    
    public partial class uchastie
    {
        public int kod_pokatushek { get; set; }
        public int kod_uchastnika { get; set; }
        public int kod_registracii { get; set; }
    
        public virtual pokatyshki pokatyshki { get; set; }
        public virtual ychastnik ychastnik { get; set; }
    }
}
