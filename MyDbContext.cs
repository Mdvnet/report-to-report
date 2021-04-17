using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportToReport.Models;

namespace ReportToReport
{
    public class AppContext : DbContext
    {
        public AppContext() : base("DbConnectionString")
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Report> Reports { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Report>().Map(m =>
            {
                m.Properties(d => new { d.Date, d.Id, d.UserLogin, d.Reason });
                m.ToTable("Reports");
            }).Map(m =>
            {
                m.Properties(d => new { d.Name, d.File });
                m.ToTable("Files");
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
