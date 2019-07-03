//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentApplicationSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class InterviewQuestionPaper
    {
        public int paperId { get; set; }
        public Nullable<int> applicationId { get; set; }
        public Nullable<int> userId { get; set; }
        public Nullable<int> question1 { get; set; }
        public Nullable<int> question2 { get; set; }
        public Nullable<int> question3 { get; set; }
        public string answer1 { get; set; }
        public string answer2 { get; set; }
        public string answer3 { get; set; }
        public Nullable<int> cd_creater { get; set; }
        public Nullable<System.DateTime> dt_created { get; set; }
        public Nullable<int> cd_modifier { get; set; }
        public Nullable<System.DateTime> dt_modified { get; set; }
    
        public virtual Application Application { get; set; }
        public virtual User User { get; set; }
        public virtual Question Question { get; set; }
        public virtual Question Question4 { get; set; }
        public virtual Question Question5 { get; set; }
    }
}
