using Api.TesteDeliverId.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.TesteDeliverId.Context
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Account> Accounts { get; set; }


        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Account>()
            //    .Property(p => p.Name)
            //    .IsRequired()
            //    .HasColumnType("nvarchar(200)");

            //modelBuilder.Entity<Account>()
            //    .Property(p => p.Value)
            //    .IsRequired()
            //    .HasColumnType("decimal(18, 2)");

            //modelBuilder.Entity<Account>()
            //    .Property(p => p.CurrentValue)
            //    .IsRequired()
            //    .HasColumnType("decimal(18, 2)");
        }
    }
}
