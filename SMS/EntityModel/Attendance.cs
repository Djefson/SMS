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
    
    public partial class Attendance
    {
        public int Id { get; set; }
        public Nullable<bool> Attended { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string AbsenceReason { get; set; }
        public Nullable<System.DateTime> CheckIn_Time { get; set; }
        public Nullable<System.DateTime> CheckOut_Time { get; set; }
    }
}
