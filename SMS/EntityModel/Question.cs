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
    
    public partial class Question
    {
        internal string question;
        internal string Exam_name;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question()
        {
            this.Exam_Details = new HashSet<Exam_Details>();
        }
    
        public int Id { get; set; }
        public string Question1 { get; set; }
        public Nullable<bool> Option1 { get; set; }
        public Nullable<bool> Option2 { get; set; }
        public Nullable<bool> Option3 { get; set; }
        public Nullable<bool> Option4 { get; set; }
        public string CorrectOption { get; set; }
        public string Explanation { get; set; }
        public Nullable<int> SubjectID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exam_Details> Exam_Details { get; set; }
        public virtual Subject Subject { get; set; }
    }
}