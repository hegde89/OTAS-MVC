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
    using System.ComponentModel.DataAnnotations;

    public partial class RID_TABLE
    {
        public string RID { get; set; }
        [Required]
        public decimal A1 { get; set; }
        [Required]
        public decimal A2 { get; set; }
        [Required]
        public decimal A3 { get; set; }
        [Required]
        public decimal A4 { get; set; }
        [Required]
        public decimal A5 { get; set; }
        [Required]
        public decimal A6 { get; set; }
        [Required]
        public decimal A7 { get; set; }
        [Required]
        public decimal A8 { get; set; }
        [Required]
        public decimal A9 { get; set; }
        [Required]
        public decimal A10 { get; set; }
    
        public virtual SubComb SubComb { get; set; }
    }
}
