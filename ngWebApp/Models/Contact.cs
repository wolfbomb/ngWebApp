//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ngWebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contact
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Details { get; set; }
        public int CategoryId { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Employee Employee { get; set; }
    }
}