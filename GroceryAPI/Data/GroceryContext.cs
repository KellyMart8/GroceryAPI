using System;
using System.Collections.Generic;
using System.Diagnostics;
using GroceryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GroceryAPI.Data;

public class GroceryContext : DbContext
{
    public GroceryContext(DbContextOptions options) : base(options) { }
    public DbSet<Branch> Branches => Set<Branch>(); 
    public DbSet<Product> Products => Set<Product>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Branch>().HasData(
            new Branch()
            {
                Id = 1,
                BranchName = "M&M's",
                Location = "Bodega"
            },
            new Branch()
            {
                Id = 2,
                BranchName = "Hershey's",
                Location = "Multicentro las americas"
            });
        modelBuilder.Entity<Product>().HasData(
            new Product()
            {
                ProductId = 1,
                Brand = "Hershey's",
                Name = "Barra pequeña de chocolate con leche",
                BranchId = 2

            },
            new Product()
            {
                ProductId = 2,
                Brand = "Hershey's",
                Name = "Barra pequeña de chocolate negro",
                BranchId = 2

            },
            new Product()
            {
                ProductId = 2,
                Brand = "M&M's",
                Name = "Mani con leche",
                BranchId = 1
            });
    }
}