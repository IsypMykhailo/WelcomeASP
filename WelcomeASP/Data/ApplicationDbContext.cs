using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WelcomeASP.Data;
using WelcomeASP.Data.Entities;

namespace WelcomeASP.Data
{
    public class ApplicationDbContext : IdentityDbContext<MyIdentityUser>
    {
        public DbSet<Entities.Faq> Faqs { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<WelcomeASP.Data.Entities.Pricing> Pricing { get; set; }
        public DbSet<Entities.Portfolio.PortfolioItem> PortfolioItems { get; set; }
        public DbSet<Entities.Portfolio.PortfolioCategory> PortfolioCategories { get; set; }

        public DbSet<Entities.trello.Board> Boards { get; set; }

        public DbSet<Entities.trello.Card> Cards { get; set; }

        public DbSet<Entities.trello.Column> Columns { get; set; }
        public DbSet<Entities.trello.TrelloTag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Entities.trello.Board>()
                .HasMany(b => b.Tags)
                .WithMany(t => t.Boards)
                .UsingEntity(j => j.ToTable("BoardTags"));
        }
    }
}
