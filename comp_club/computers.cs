//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace comp_club
{
    using System;
    using System.Collections.Generic;
    
    public partial class computers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public computers()
        {
            this.admin = new HashSet<admin>();
        }
    
        public int id { get; set; }
        public Nullable<int> address_comp { get; set; }
        public Nullable<int> user_is_sitting { get; set; }
        public Nullable<System.TimeSpan> time_of_working { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<admin> admin { get; set; }
        public virtual user_A user_A { get; set; }
    }
}
