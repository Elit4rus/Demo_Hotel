//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo_Hotel.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public System.DateTime RegistrationDate { get; set; }
        public bool IsActivatedID { get; set; }
        public bool IsBlocked { get; set; }
        public int RoleID { get; set; }
    
        public virtual Role Role { get; set; }
    }
}
