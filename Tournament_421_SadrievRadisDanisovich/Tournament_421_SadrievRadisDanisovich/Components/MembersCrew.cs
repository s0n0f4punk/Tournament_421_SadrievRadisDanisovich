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
    
    public partial class MembersCrew
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public Nullable<int> Id_TournamentMember { get; set; }
    
        public virtual TornamentMembers TornamentMembers { get; set; }
    }
}
