using Microsoft.EntityFrameworkCore;
using System;
using WarehouseAccountingSystem.Entities;

namespace WarehouseAccountingSystem.AppContext
{
    public class AppDbContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Balance> Balance { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<StringsOrder> StringsOrders { get; set; }
        public DbSet<Receipt> Receipts { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>().HasOne(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryId);
            builder.Entity<Product>().HasOne(p => p.Color).WithMany(c => c.Products).HasForeignKey(p => p.ColorId);
            builder.Entity<Balance>().HasOne(b => b.Product).WithMany(p => p.Balance).HasForeignKey(b => b.ProductId);
            base.OnModelCreating(builder);

            builder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    CategoryName = "Таблички"
                },
                new Category
                {
                    Id = 2,
                    CategoryName = "Покрывала"
                },
                new Category
                {
                    Id = 3,
                    CategoryName ="Наволочки"    
                },
                new Category
                {
                    Id = 4,
                    CategoryName = "Рушники"
                },
                new Category
                {
                    Id = 5,
                    CategoryName = "Салфетки"
                },
                new Category
                {
                    Id = 6,
                    CategoryName = "Платки"
                }
                );
            builder.Entity<Color>().HasData(
                new Color
                {
                    Id = 1,
                    ColorName = "Черный"
                },
                new Color
                {
                    Id = 2,
                    ColorName = "Белый"
                },
                new Color
                {
                    Id = 3,
                    ColorName = "Бордовый"
                },
                new Color
                {
                    Id = 4,
                    ColorName = "Синий"
                }
                );
            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    ProductName="Табличка пластик 18х25",
                    Cost = 7.50m,
                    CategoryId = 1,
                    ColorId =1
                },
                new Product
                {
                    Id = 2,
                    ProductName = "Табличка пластик 20х25",
                    Cost = 8.50m,
                    CategoryId = 1,
                    ColorId = 1
                },
                 new Product
                 {
                     Id = 3,
                     ProductName = "Табличка литьё",
                     Cost = 11.00m,
                     CategoryId = 1,
                     ColorId = 1
                 },
                new Product
                {
                    Id = 4,
                    ProductName = "Табличка металл",
                    Cost = 15.80m,
                    CategoryId = 1,
                    ColorId = 2
                },

                 new Product
                 {
                     Id = 5,
                     ProductName = "Покрывало рюш шелк",
                     Cost = 60.00m,
                     CategoryId = 2,
                     ColorId = 2
                 },
                new Product
                {
                    Id = 6,
                    ProductName = "Покрывало рюш атлас",
                    Cost = 95.00m,
                    CategoryId = 2,
                    ColorId = 3
                },
                 new Product
                 {
                     Id = 7,
                     ProductName = "Наволочка жатка",
                     Cost = 27.50m,
                     CategoryId = 3,
                     ColorId = 2
                 },
                new Product
                {
                    Id = 8,
                    ProductName = "Рушник габардин 36",
                    Cost = 32.50m,
                    CategoryId = 4,
                    ColorId = 2
                }
                );
        }
    }
}
