namespace KütüphaneOtomasyonuCemal
{
    using Class;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class KütüphaneModel : DbContext
    {
        public KütüphaneModel()
            : base("name=KütüphaneModel")
        {

        }
        public virtual DbSet<Kitap> Kitap { get; set; }
        public virtual DbSet<Yazar> Yazar { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<İslem> İslem { get; set; }
    }
}