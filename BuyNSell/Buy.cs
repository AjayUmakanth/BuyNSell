//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BuyNSell
{
    using System;
    using System.Collections.Generic;
    
    public partial class Buy
    {
        public int PID { get; set; }
        public int Area { get; set; }
        public int Rooms { get; set; }
        public int NoFloors { get; set; }
        public int Floor { get; set; }
        public int Parking { get; set; }
        public int Road { get; set; }
        public System.DateTime RegYear { get; set; }
        public bool Garden { get; set; }
        public bool Corner { get; set; }
        public string Additional { get; set; }
        public byte[] Photo { get; set; }
    
        public virtual Property Property { get; set; }
    }
}
