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
    
    public partial class appointment
    {
        public int apointmentId { get; set; }
        public Nullable<int> patientId { get; set; }
        public Nullable<int> doctorId { get; set; }
        public string starttime { get; set; }
        public string endtime { get; set; }
        public string doctornotes { get; set; }
        public string patientnotes { get; set; }
        public Nullable<int> apointmentprice { get; set; }
        public Nullable<decimal> rating { get; set; }
        public Nullable<System.DateTime> BookingDate { get; set; }
        public string dosage { get; set; }
        public string dosagefrequency { get; set; }
        public string medicationinstructions { get; set; }
        public Nullable<int> confirmappointment { get; set; }
        public string JoinUrl { get; set; }
    
        public virtual doctor doctor { get; set; }
        public virtual patient patient { get; set; }
    }
}
