namespace CodeFirst_Sample_2.DBCon
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MarketContext : DbContext
    {        
        public MarketContext()
            : base("name=MarketContext")
        {

        }   
             
        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.ProductPrice).HasColumnType("money");
        }
    }   
}