using Microsoft.EntityFrameworkCore;
using Sakila.Persistent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMap.Domain;

namespace UserMap.Persistent
{
    public class UserMapContext : AuditTableDbContext
    {
        public UserMapContext(DbContextOptions<SakilaContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SakilaContext).Assembly);
        }
        public DbSet<Ads> Ads { get; set; }

    }
}
