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
    
    public partial class Valid
    {
        public string USN { get; set; }
        public string PASSGEN { get; set; }
        public int COUNTER { get; set; }
        public bool FG { get; set; }
        public bool STUDENTDETAILS { get; set; }
    
        public virtual STUDENT STUDENT { get; set; }
    }
}
