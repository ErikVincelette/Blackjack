﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Blackjack_DBEntities1 : DbContext
    {
        public Blackjack_DBEntities1()
            : base("name=Blackjack_DBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Dealer_DB> Dealer_DB { get; set; }
        public virtual DbSet<Deck_DB> Deck_DB { get; set; }
        public virtual DbSet<Discard_DB> Discard_DB { get; set; }
        public virtual DbSet<New_Deck_DB> New_Deck_DB { get; set; }
        public virtual DbSet<Ontable_DB> Ontable_DB { get; set; }
        public virtual DbSet<Player_hands_DB> Player_hands_DB { get; set; }
        public virtual DbSet<Players_DB> Players_DB { get; set; }
        public virtual DbSet<Saves_DB> Saves_DB { get; set; }
    }
}