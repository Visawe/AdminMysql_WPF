//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LaravelAdminMysql
{
    using System;
    using System.Collections.Generic;
    
    public partial class task_file
    {
        public long id { get; set; }
        public long task_id { get; set; }
        public string path { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public string name { get; set; }
    
        public virtual task task { get; set; }
    }
}
