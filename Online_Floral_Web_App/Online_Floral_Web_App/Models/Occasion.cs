//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Online_Floral_Web_App.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Occasion
    {
        public Occasion()
        {
            this.bouquet = new HashSet<bouquet>();
            this.messages = new HashSet<messages>();
        }
    
        public int Occasionid { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<bouquet> bouquet { get; set; }
        public virtual ICollection<messages> messages { get; set; }
    }
}
