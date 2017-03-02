namespace IMDBCemal.Entity
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ImdbDBContext : DbContext
    {
        public ImdbDBContext()
            : base("name=ImdbDB")
        {
        }
        public virtual DbSet<Film> Film { get; set; }
        public virtual DbSet<Tur> Tur { get; set; }
        public virtual DbSet<Yonetmen> Yonetmen { get; set; }
    }
}