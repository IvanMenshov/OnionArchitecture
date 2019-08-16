using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentOnionWebApi.Infrastructure.Models;
using StudentOnionWebApi.InfrastructureService.Configuration;

namespace StudentOnionWebApi.InfrastructureService.Context
{
    public class MyContext : DbContext
    {
        public virtual DbSet<University> Universities { get; set; }
        public virtual DbSet<RequestLog> RequestLogs { get; set; }
        public virtual DbSet<ExceptionLog> ExceptionLogs { get; set; }

        public MyContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
            base.OnModelCreating(modelBuilder.ApplyConfiguration(new UniversityConfigurtion())
                .ApplyConfiguration(new LogConfiguration())
                .ApplyConfiguration(new ExceptionConfiguration()));

    }
}
