//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectOperationServices.Models
{
    using System;
    
    public partial class sp_fetch_tblstudent_payments_Result
    {
        public int payment_id { get; set; }
        public int registration_id { get; set; }
        public Nullable<System.DateTime> payment_date { get; set; }
        public Nullable<double> payment_amount { get; set; }
        public string payment_mode { get; set; }
        public string payment_description { get; set; }
        public Nullable<int> student_id { get; set; }
        public Nullable<int> course_id { get; set; }
        public Nullable<System.DateTime> registration_date { get; set; }
        public Nullable<double> discount { get; set; }
    }
}
