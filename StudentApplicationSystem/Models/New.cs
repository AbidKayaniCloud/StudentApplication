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
    using System.Web;

    public partial class New
    {
        [Key]
        public int newId { get; set; }
        [DisplayName("Header")]
        public string header { get; set; }
        
        public string text { get; set; }
        public byte[] image { get; set; }
        public Nullable<int> featured { get; set; }

        public bool BoolValue
        {
            // This function sets the int admin value by using checkbox in forms.
            get { return featured == 1; }
            set { featured = value ? 1 : 0; }
        }

        public string featuredList { get; set; }
        [DisplayName("Created")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> dt_created { get; set; }
        [DisplayName("Modified")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> dt_modified { get; set; }
        [DisplayName("Created By")]
        public Nullable<int> cd_creater { get; set; }
        [DisplayName("Modified By")]
        public Nullable<int> cd_modifier { get; set; }
        [Required(ErrorMessage = "Please select file.")]
        public HttpPostedFileBase imageFile { get; set; }
    }
}
