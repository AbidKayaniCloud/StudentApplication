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
    
    public partial class Application
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Application()
        {
            this.InterviewQuestionPapers = new HashSet<InterviewQuestionPaper>();
        }
    
        public int applicationId { get; set; }
        public int userId { get; set; }
        public byte[] cv { get; set; }
        public Nullable<int> paperId { get; set; }
        public Nullable<System.DateTime> dt_created { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InterviewQuestionPaper> InterviewQuestionPapers { get; set; }
        public virtual User User { get; set; }
    }
}
