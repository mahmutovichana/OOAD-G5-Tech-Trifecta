using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TheSmartCafe.Model;

namespace SmartCafe.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Bartender> Bartenders { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<DrinkIngredient> DrinkIngredients { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Guest>().ToTable("Guest");
            modelBuilder.Entity<Bartender>().ToTable("Bartender");
            modelBuilder.Entity<Drink>().ToTable("Drink");
            modelBuilder.Entity<Ingredient>().ToTable("Ingredient");
            modelBuilder.Entity<Owner>().ToTable("Owner");
            modelBuilder.Entity<Statistic>().ToTable("Statistic");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<OrderItem>().ToTable("OrderItem");
            modelBuilder.Entity<DrinkIngredient>().ToTable("DrinkIngredient");
            base.OnModelCreating(modelBuilder);
        }
    }
}
