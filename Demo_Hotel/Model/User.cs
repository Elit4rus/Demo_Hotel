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
        public User()
        {
            this.Booking = new HashSet<Booking>();
        }
    
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public System.DateTime RegistrationDate { get; set; }
        public bool IsActivated { get; set; }
        public bool IsBlocked { get; set; }
        public int RoleId { get; set; }
    
        public virtual ICollection<Booking> Booking { get; set; }
        public virtual Role Role { get; set; }
    }
}
