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
    
    public partial class Asset
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }      
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    }
}
