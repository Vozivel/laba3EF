//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace laba3EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Games
    {
        public int ID_Game { get; set; }
        public string Game_Name { get; set; }
        public Nullable<int> Developers_ID { get; set; }
        public Nullable<int> Platform_ID { get; set; }
    
        public virtual Developers Developers { get; set; }
        public virtual Platforms Platforms { get; set; }
    }
}
