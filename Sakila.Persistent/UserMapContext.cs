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
        public UserMapContext(DbContextOptions<UserMapContext> options) : base(options)
        {
        }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserMapContext).Assembly);
        }
        public DbSet<Ads> Ads { get; set; }
        public DbSet<ReportWarm> ReportWarm { get; set; }
    }
}
