//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OtdelKadrov
{
    using System;
    using System.Collections.Generic;
    
    public partial class document
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public document()
        {
            this.links = new HashSet<link>();
        }
    
        public int id { get; set; }
        public int Номер_документа { get; set; }
        public System.DateTime Дата_документа { get; set; }
        public string Тип_документа__приход__расход_ { get; set; }
        public string Описание_документа { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<link> links { get; set; }
    }
}
