//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tournament_421_SadrievRadisDanisovich.Components
{
    using System;
    using System.Collections.Generic;
    
    public partial class TornamentMembers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TornamentMembers()
        {
            this.Match = new HashSet<Match>();
            this.Match1 = new HashSet<Match>();
            this.Match2 = new HashSet<Match>();
            this.MembersCrew = new HashSet<MembersCrew>();
        }
    
        public int Id { get; set; }
        public Nullable<int> Id_Tournament { get; set; }
        public Nullable<int> Id_Competitor { get; set; }
        public Nullable<int> Id_Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Match> Match { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Match> Match1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Match> Match2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MembersCrew> MembersCrew { get; set; }
        public virtual RequestStatus RequestStatus { get; set; }
        public virtual User User { get; set; }
        public virtual Tournament Tournament { get; set; }
    }
}
