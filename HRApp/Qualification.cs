//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Qualification
    {
        public int id { get; set; }
        public string QualificationName { get; set; }
        public Nullable<System.DateTime> DateCompleted { get; set; }
        public string Notes { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public Nullable<int> employeeId { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
