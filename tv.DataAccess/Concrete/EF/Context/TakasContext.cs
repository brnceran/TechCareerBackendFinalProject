using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tv.Core.Entity.Concrete;
using tv.Entity.Concrete;

namespace tv.DataAccess.Concrete.EF.Context
{
    public class TakasContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString: @"Server=.;Database=TV;Integrated Security=True;TrustServerCertificate=true");
        }
        public DbSet<Advert> Adverts { get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<User> Users{ get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims{ get; set; }
        public DbSet<OperationClaim> OperationClaims{ get; set; }
    }
}
