//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ABC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AttendanceCount
    {
        public string USN { get; set; }
        public string Subject { get; set; }
        public Nullable<int> Attended { get; set; }
        public Nullable<int> I1 { get; set; }
        public Nullable<int> I2 { get; set; }
        public Nullable<int> I3 { get; set; }
    
        public virtual STUDENT STUDENT { get; set; }
        public virtual Subject Subject1 { get; set; }
    }
}
