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
    public class ExceptionConfiguration : IEntityTypeConfiguration<ExceptionLog>
    {
        public void Configure(EntityTypeBuilder<ExceptionLog> builder)
        {
            builder.ToTable("ExceptionLogs");
            builder.HasKey(_ => _.Id);
        }
    }
}
