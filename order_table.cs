//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication4
{
    using System;
    using System.Collections.Generic;
    
    public partial class order_table
    {
        public int o_id { get; set; }
        public System.DateTime o_date { get; set; }
        public int c_id { get; set; }
        public int f_id { get; set; }
        public int qty { get; set; }
        public int unit_price { get; set; }
        public long total { get; set; }
        public string offer { get; set; }
    
        public virtual customer_master customer_master { get; set; }
        public virtual menu_master menu_master { get; set; }
    }
}
