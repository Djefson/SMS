//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMS.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Internship
    {
        public int Id { get; set; }
        public Nullable<int> StudentId { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string CompanyName { get; set; }
        public string ContactPerson { get; set; }
        public Nullable<int> ContactPhoneNumber { get; set; }
        public string ContactEmail { get; set; }
        public string City { get; set; }
        public string Technologies { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
