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
    
    public partial class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> FUB_StartDate { get; set; }
        public Nullable<System.DateTime> FUB_EndDate { get; set; }
        public Nullable<int> FUB_TotDays { get; set; }
        public Nullable<System.DateTime> AUB_EndDate { get; set; }
        public Nullable<int> AUB_TotDays { get; set; }
        public string Location { get; set; }
        public Nullable<int> TeacherId { get; set; }
        public Nullable<int> StudentId { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}