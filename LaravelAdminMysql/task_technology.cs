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
    
    public partial class task_technology
    {
        public long id_task { get; set; }
        public long id_technology { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    
        public virtual task task { get; set; }
        public virtual technology technology { get; set; }
    }
}
