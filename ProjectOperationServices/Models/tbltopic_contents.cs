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
    using System.Collections.Generic;
    
    public partial class tbltopic_contents
    {
        public int content_id { get; set; }
        public Nullable<int> topic_id { get; set; }
        public string content_name { get; set; }
        public Nullable<int> flage { get; set; }
    
        public virtual tbltraining_topics tbltraining_topics { get; set; }
    }
}
