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

        public virtual DbSet<�gretmenKart> �gretmenKart { get; set; }
        public virtual DbSet<�grenciKart> �grenciKart { get; set; }
        public virtual DbSet<Kart> Kart { get; set; }

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }
}