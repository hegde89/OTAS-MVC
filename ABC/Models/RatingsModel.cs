using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ABC.Models
{
    public class RatingsModel : RID_TABLE
    {
        public string Subcode { get; set; }
        public string SubName { get; set; }
        public string TeacherName { get; set; }

    }
}