//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestWCFService.BusinessObjects
{
    using System;
    using System.Collections.Generic;
    
    public partial class ETDDetail
    {
        public int Etd_id { get; set; }
        public Nullable<int> driver_id { get; set; }
        public Nullable<int> trip_id { get; set; }
        public Nullable<System.DateTime> Etd_Date { get; set; }
        public string Origin { get; set; }
        public string destination { get; set; }
    
        public virtual DriverDetail DriverDetail { get; set; }
    }
}
