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
    
    public partial class LessonView
    {
        public int LessonViewedId { get; set; }
        public string UserId { get; set; }
        public int LessonId { get; set; }
        public System.DateTime DateViewed { get; set; }
    
        public virtual Lesson Lesson { get; set; }
        public virtual UserDetail UserDetail { get; set; }
    }
}
