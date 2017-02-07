namespace Kentkart_OOP.DBCon
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class KentKartDB : DbContext
    {

        public KentKartDB()
            : base("name=KentKartDB")
        {

        }

        public virtual DbSet<ÖgretmenKart> ÖgretmenKart { get; set; }
        public virtual DbSet<ÖgrenciKart> ÖgrenciKart { get; set; }
        public virtual DbSet<Kart> Kart { get; set; }

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }
}