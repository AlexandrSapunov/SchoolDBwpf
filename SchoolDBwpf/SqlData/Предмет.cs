//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolDBwpf.SqlData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Предмет
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Предмет()
        {
            this.ЖурналПосещаемости = new HashSet<ЖурналПосещаемости>();
            this.ЖурналУспеваемости = new HashSet<ЖурналУспеваемости>();
        }
    
        public int КодПредмета { get; set; }
        public string Название { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ЖурналПосещаемости> ЖурналПосещаемости { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ЖурналУспеваемости> ЖурналУспеваемости { get; set; }
    }
}
