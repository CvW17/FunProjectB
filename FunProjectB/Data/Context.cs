#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FunProjectB.Models;

namespace FunProjectB.Data
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<FunProjectB.Models.Continents> Continents { get; set; }

        public DbSet<FunProjectB.Models.Cities> Cities { get; set; }

        public DbSet<FunProjectB.Models.Countries> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FunProjectB.Models.Cities>().ToTable("Cities");
            modelBuilder.Entity<FunProjectB.Models.Countries>().ToTable("Countries");
            modelBuilder.Entity<FunProjectB.Models.Continents>().ToTable("Continents");
        }
    }
}
