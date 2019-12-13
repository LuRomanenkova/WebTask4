﻿using Microsoft.EntityFrameworkCore;
namespace WebApplicationTask4.Models
{
    public sealed class PerfumeContext : DbContext
    {
        public DbSet<Perfume> Perfumes { get; set; }
        public DbSet<Brand> Brands { get; set; }
        
        public PerfumeContext(DbContextOptions<PerfumeContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}