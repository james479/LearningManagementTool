//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS.DATA.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class TestScore
    {
        public int TestScoreId { get; set; }
        public string UserId { get; set; }
        public int LessonId { get; set; }
        public double Score { get; set; }
    
        public virtual Lesson Lesson { get; set; }
        public virtual UserDetail UserDetail { get; set; }
    }
}
