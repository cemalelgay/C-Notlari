namespace MVC_CRUD.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CarDBContext : DbContext
    {

        public CarDBContext()
            : base("name=CarDB")
        {
        }

        public virtual DbSet<Car> Car { get; set; }

    }
}