using HexaMazeRetreat.Blazor.Entities;
using HexaMazeRetreat.Blazor.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HexaMazeRetreat.Blazor.DataAccess
{
    public class HexaMazeRetreatDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DbSet<Play> Plays { get; set; }

        public HexaMazeRetreatDbContext(
            IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string connectionString = _configuration.GetConnectionString();
            string connectionString = @"Server=.\SQLDEV;Database=HexaMazeRetreat2021;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Play>(e =>
            {
                e.ToTable("PLAYS");
                e.HasKey(k => k.Id).IsClustered(false);
                e.HasIndex(i => i.SysId).IsUnique().IsClustered();
                e.Property(p => p.SysId).ValueGeneratedOnAdd();
            });
        }
    }
}