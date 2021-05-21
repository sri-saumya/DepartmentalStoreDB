using Microsoft.EntityFrameworkCore;
using Store.Domain;
using System;

namespace Store.Data
{
    public class StoreContext:DbContext
    {
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductHistory> ProductHistory { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;DataBase=DepartmentalStoreEF;UserName=postgres;Password=1234");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Department
            modelBuilder.Entity<Department>().HasKey(k => k.Id);
            modelBuilder.Entity<Department>().Property(r => r.DepartmentName).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Department>().Property(r => r.Description).HasMaxLength(256).IsRequired();


            //Staff
            modelBuilder.Entity<Staff>().HasKey(r => r.Id);
            modelBuilder.Entity<Staff>().Property(r => r.FirstName).HasMaxLength(30).IsRequired(); 
            modelBuilder.Entity<Staff>().Property(r => r.LastName).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Staff>().Property(r => r.Gender).HasMaxLength(6).IsRequired();
            modelBuilder.Entity<Staff>().Property(r => r.PhoneNumber).HasMaxLength(10).IsRequired();
            modelBuilder.Entity<Staff>().HasOne(s => s.Department).WithMany(d => d.Staffs).HasForeignKey(s => s.DepartmentId);


            //Address
            modelBuilder.Entity<Address>().HasKey(r => r.Id);
            modelBuilder.Entity<Address>().Property(r => r.AddressLine1).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Address>().Property(r => r.AddressLine2).HasMaxLength(30);
            modelBuilder.Entity<Address>().Property(r => r.City).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Address>().Property(r => r.State).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Address>().Property(r => r.Country).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Address>().Property(r => r.PinCode).HasMaxLength(6).IsRequired();
            modelBuilder.Entity<Address>().HasOne(f => f.Staff).WithOne(d => d.Address).HasForeignKey<Address>(s => s.StaffId);


            //Product
            modelBuilder.Entity<Product>().HasKey(r => r.Id);
            modelBuilder.Entity<Product>().Property(r => r.ProductName).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Product>().Property(r => r.ShortCode).HasMaxLength(6).IsRequired();
            modelBuilder.Entity<Product>().Property(r => r.SellingPrice).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Product>().Property(r => r.CostPrice).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Product>().Property(r => r.Manufacturer).HasMaxLength(30).IsRequired();


            //Category
            modelBuilder.Entity<Category>().HasKey(r => r.Id);
            modelBuilder.Entity<Category>().Property(r => r.CategoryName).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Category>().Property(r => r.ShortCode).HasMaxLength(6).IsRequired();


            //ProductCategory
            modelBuilder.Entity<ProductCategory>().HasKey(pc => new { pc.ProductId, pc.CategoryId });


            //Inventory
            modelBuilder.Entity<Inventory>().HasKey(r => r.Id);
            modelBuilder.Entity<Inventory>().Property(r => r.Quantity).HasMaxLength(10).IsRequired();
            modelBuilder.Entity<Inventory>().Property(r => r.InStock).HasMaxLength(1).IsRequired();
            modelBuilder.Entity<Inventory>().HasOne(r => r.Product).WithOne(d => d.Inventory).HasForeignKey<Inventory>(s => s.ProductId);


            //Supplier
            modelBuilder.Entity<Supplier>().HasKey(r => r.Id);
            modelBuilder.Entity<Supplier>().Property(r => r.FirstName).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Supplier>().Property(r => r.LastName).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Supplier>().Property(r => r.Gender).HasMaxLength(6).IsRequired();
            modelBuilder.Entity<Supplier>().Property(r => r.PhoneNumber).HasMaxLength(10).IsRequired();
            modelBuilder.Entity<Supplier>().Property(r => r.Email).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Supplier>().Property(r => r.City).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Supplier>().Property(r => r.State).HasMaxLength(30).IsRequired();


            //SupplierProduct
            modelBuilder.Entity<SupplierProduct>().HasKey(pc => new { pc.ProductId, pc.SupplierId });


            //ProductHistory
            modelBuilder.Entity<ProductHistory>().HasKey(r => r.Id);
            modelBuilder.Entity<ProductHistory>().Property(r => r.Quantity).HasMaxLength(10).IsRequired();
            modelBuilder.Entity<ProductHistory>().Property(r => r.OrderDate).HasMaxLength(12).IsRequired();
            modelBuilder.Entity<ProductHistory>().Property(r => r.SupplyDate).HasMaxLength(12).IsRequired();
            modelBuilder.Entity<ProductHistory>().HasOne(r => r.Product).WithOne(d => d.ProductHistory).HasForeignKey<ProductHistory>(s => s.ProductId);


        }
    }
}
