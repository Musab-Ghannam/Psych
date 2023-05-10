//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mainMasterpiesce.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class doctor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public doctor()
        {
            this.appointments = new HashSet<appointment>();
            this.feedbacks = new HashSet<feedback>();
            this.NotAvailableTimes = new HashSet<NotAvailableTime>();
            this.transactionsdoctors = new HashSet<transactionsdoctor>();
            this.patients = new HashSet<patient>();
        }
    
        public int doctorId { get; set; }
        public string Id { get; set; }
    
        public string locationdoctor { get; set; }

        public string doctorName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string qualiification { get; set; }

        public string specialization { get; set; }
        public Nullable<System.DateTime> startedate { get; set; }
        public string idCardfile { get; set; }
        public string picdoctor { get; set; }
        public string certificationfile { get; set; }
        public string birthfile { get; set; }
        public Nullable<int> specializationId { get; set; }
        public Nullable<int> statedoctor { get; set; }
        public Nullable<double> earningDoctortotal { get; set; }
        public Nullable<double> AmountsDue { get; set; }
        public string IBAN { get; set; }
        public Nullable<bool> Gender { get; set; }
        public string infodoctor { get; set; }
        public Nullable<double> pricePerHour { get; set; }
        public Nullable<double> ratingdoctor { get; set; }
        public Nullable<int> ratingint { get; set; }
        public string experience { get; set; }

        public Nullable<System.DateTime> birthday { get; set; }
        public string addresss { get; set; }
        public string educationdetails { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<appointment> appointments { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual specialization specialization1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<feedback> feedbacks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotAvailableTime> NotAvailableTimes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transactionsdoctor> transactionsdoctors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<patient> patients { get; set; }
    }
}