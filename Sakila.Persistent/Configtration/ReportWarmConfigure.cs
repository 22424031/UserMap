using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMap.Domain;

namespace UserMap.Persistent.Configtration
{
    public class ReportWarmConfigure : IEntityTypeConfiguration<ReportWarm>
    {
    

        public void Configure(EntityTypeBuilder<ReportWarm> builder)
        {
            builder.Ignore(x => x.UrlString);
            builder.HasKey(x => x.ReportWarmID);
            builder.Property(x=> x.WarmType).IsRequired();
            builder.Property(x => x.Email).HasColumnType("varchar(128)").IsRequired();
            builder.Property(x => x.FullName).IsRequired().HasColumnType("varchar(20)").HasMaxLength(20);
            builder.Property(x => x.PhoneNumber).IsRequired().HasColumnType("varchar(15)").HasMaxLength(15);
            builder.Property(x => x.UrlStringJson).HasColumnType("Json").IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.Feedback).HasMaxLength(300);
        }
    }
}
