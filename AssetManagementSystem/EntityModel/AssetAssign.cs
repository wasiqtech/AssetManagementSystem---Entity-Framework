//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AssetManagementSystem.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class AssetAssign
    {
        public int Id { get; set; }
        public Nullable<int> FK_EmployeeInformation { get; set; }
        public Nullable<int> FK_Asset { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "This Field Can not be Empty")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime CreatedOn { get; set; }
        public string CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    }
}
