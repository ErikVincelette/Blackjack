//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Blackjack
{
    using System;
    using System.Collections.Generic;
    
    public partial class Player_hands_DB
    {
        public int id { get; set; }
        public int player_id { get; set; }
        public int hand { get; set; }
        public string image_name { get; set; }
    
        public virtual Players_DB Players_DB { get; set; }
    }
}
