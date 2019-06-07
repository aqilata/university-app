//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniversityApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.Evaluations = new HashSet<Evaluation>();
            this.Grades = new HashSet<Grade>();
        }
    
        public int ID { get; set; }
        public string Identifier { get; set; }
        public Nullable<System.DateTime> Birthdate { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Nullable<int> GroupID { get; set; }
        public string Password { get; set; }
        public Nullable<bool> Status { get; set; }
        public string FatherName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evaluation> Evaluations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grade> Grades { get; set; }
        public virtual Group Group { get; set; }
    }

    
}
