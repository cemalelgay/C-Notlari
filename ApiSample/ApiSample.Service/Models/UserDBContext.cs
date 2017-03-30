namespace ApiSample.Service.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class UserDBContext : DbContext
    {

        public UserDBContext()
            : base("name=UserDB")
        {
            Database.SetInitializer(new Configuration());
        }

        public virtual DbSet<User> User { get; set; }

        public class Configuration : CreateDatabaseIfNotExists<UserDBContext>
        {
            protected override void Seed(UserDBContext context)
            {
                context.User.Add(new User()
                {
                    FirstName = "Cemal",
                    LastName = "Elgay"
                });
                context.SaveChanges();
            }
        }
    }
}