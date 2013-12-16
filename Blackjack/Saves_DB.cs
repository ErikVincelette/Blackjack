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
    
    public partial class Saves_DB
    {
        public Saves_DB()
        {
            this.Dealer_DB = new HashSet<Dealer_DB>();
            this.Deck_DB = new HashSet<Deck_DB>();
            this.Discard_DB = new HashSet<Discard_DB>();
            this.Ontable_DB = new HashSet<Ontable_DB>();
            this.Players_DB = new HashSet<Players_DB>();
        }
    
        public int id { get; set; }
        public string save_name { get; set; }
        public int active_player { get; set; }
        public int active_players { get; set; }
    
        public virtual ICollection<Dealer_DB> Dealer_DB { get; set; }
        public virtual ICollection<Deck_DB> Deck_DB { get; set; }
        public virtual ICollection<Discard_DB> Discard_DB { get; set; }
        public virtual ICollection<Ontable_DB> Ontable_DB { get; set; }
        public virtual ICollection<Players_DB> Players_DB { get; set; }
    }
}
