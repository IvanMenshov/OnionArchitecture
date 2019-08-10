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
    public class UniversityConfigurtion : IEntityTypeConfiguration<University>
    {
        public void Configure(EntityTypeBuilder<University> builder)
        {
            builder.ToTable("Universities");
            builder.HasKey(_ => _.UniversityId);
        }
    }
}
