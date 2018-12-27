using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication2.Models
{
    public partial class DVchocContext : DbContext
    {
        public DVchocContext()
        {
        }

        public DVchocContext(DbContextOptions<DVchocContext> options)
            : base(options)
        {
        }

        // Unable to generate entity type for table 'dbo.tbl_ClockIn'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_ClockOut'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:dv-server1234567.database.windows.net,1433;Initial Catalog=DVchoc;Persist Security Info=False;User ID=andredev1234567;Password=Kooler1234567;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}
    }
}
