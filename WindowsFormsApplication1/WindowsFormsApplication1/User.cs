//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.Books = new HashSet<Book>();
        }
    
        public string NameUser { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public string Gmail { get; set; }
        public string Gender { get; set; }
    
        public virtual ICollection<Book> Books { get; set; }
    }
}
