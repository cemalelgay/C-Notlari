namespace KutuphaneOtomasyon.Entity.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class KutuphaneDBContext : DbContext
    {
        public KutuphaneDBContext()
            : base("name=KutuphaneDB")
        {

        }

        public virtual DbSet<VMBook> Book { get; set; }
        public virtual DbSet<Writer> Writer { get; set; }
        public virtual DbSet<Rent> Rent { get; set; }
        public virtual DbSet<User> User { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}