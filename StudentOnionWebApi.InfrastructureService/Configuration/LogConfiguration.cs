using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentOnionWebApi.Infrastructure.Models;

namespace StudentOnionWebApi.InfrastructureService.Configuration
{
    public class LogConfiguration : IEntityTypeConfiguration<RequestLog>
    {
        public void Configure(EntityTypeBuilder<RequestLog> builder)
        {
            builder.ToTable("RequestLogs");
            builder.HasKey(_ => _.RequestId);
        }
    }
}
