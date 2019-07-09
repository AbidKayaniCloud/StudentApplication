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
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Applications = new HashSet<Application>();
            this.InterviewQuestionPapers = new HashSet<InterviewQuestionPaper>();
        }

        [Key]
        public int userId { get; set; }
        [DisplayName("Name")]
        public string name { get; set; }
        [DisplayName("Last Name")]
        public string surname { get; set; }

        public string printName
        {
            get
            {
                return name + " " + surname;
            }
        }

        [Required(ErrorMessage = "Email is required.")]
        [DisplayName("E-Mail")]
        [RegularExpression("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*", ErrorMessage = "Email is invalid")]
        public string email { get; set; }
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{8,15}$", ErrorMessage = "Please use one uppercase character at least.")]
        public string password { get; set; }
        [DisplayName("Department")]
        [StringLength(150)]
        public string department { get; set; }
        [DisplayName("GPA")]
        [Range(1.0, 4.0)]
        public Nullable<double> gpa { get; set; }
        [DisplayName("Contact Number")]
        //[Mask("+1 (999) 000-0000", IncludeLiterals = MaskIncludeLiteralsMode.DecimalSymbol, PromptChar = '_', ErrorMessage = "Phone number is invalid")]
        public string phone_number { get; set; }
        [DisplayName("Modified By")]
        public Nullable<int> cd_modifier { get; set; }
        [DisplayName("Modified")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> dt_modified { get; set; }
        [DisplayName("Created")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> dt_created { get; set; }
        [DisplayName("Admin?")]
        public Nullable<int> isAdmin { get; set; }
        public bool BoolValue
        {
            // This function sets the int admin value by using checkbox in forms.
            get { return isAdmin == 1; }
            set { isAdmin = value ? 1 : 0; }
        }

        public string printAdmin
        {
            get { return isAdmin == 1 ? "Yes" : "No"; }
            set { }
        }
        public string applicationList { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Application> Applications { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InterviewQuestionPaper> InterviewQuestionPapers { get; set; }
    }
}
