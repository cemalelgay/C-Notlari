namespace OzanSuDagıtım.DBConnection
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class OzanSuDagıtımModel : DbContext
    {

        public OzanSuDagıtımModel()
            : base("name=OzanSuDagıtımDB")
        {
        }

        
        public virtual DbSet<Product> Product { get; set; }
    }
}