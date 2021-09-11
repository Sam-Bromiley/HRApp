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
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Holidays = new HashSet<Holiday>();
            this.Qualifications = new HashSet<Qualification>();
        }
    
        public int id { get; set; }
        public string Surname { get; set; }
        public string Forename { get; set; }
        public string MiddleName { get; set; }
        public string KnownAs { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public Nullable<int> GenderId { get; set; }
        public string JobTitle { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Postcode { get; set; }
        public string NationalInsuranceNo { get; set; }
        public Nullable<int> MaritalStatusId { get; set; }
        public Nullable<int> OfficeLocationId { get; set; }
        public Nullable<int> ExtensionNumber { get; set; }
        public Nullable<int> ReportsToId { get; set; }
        public Nullable<int> TypeOfEmployeeId { get; set; }
        public Nullable<System.DateTime> DateStarted { get; set; }
        public Nullable<System.DateTime> DateLeft { get; set; }
        public Nullable<bool> Leaver { get; set; }
        public Nullable<int> TotalHolidays { get; set; }
        public Nullable<int> HolidaysTaken { get; set; }
        public Nullable<int> HolidaysLeft { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual MaritalStatu MaritalStatu { get; set; }
        public virtual OfficeLocation OfficeLocation { get; set; }
        public virtual TypeOfEmployee TypeOfEmployee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Holiday> Holidays { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Qualification> Qualifications { get; set; }
    }
}
