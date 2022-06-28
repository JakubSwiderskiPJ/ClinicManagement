using ClinicManagement.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClinicManagement.Infrastructure.Context;

public class MainContext : DbContext
{
    public DbSet<Doctor> Doctor { get; set; }
    public DbSet<Patient> Patient { get; set; }
    public DbSet<Visits> Visits { get; set; }
    
    public MainContext(DbContextOptions options) : base(options)
    {
        
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=dbo.ClinicManagement.db");
    }
}