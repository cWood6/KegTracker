using KegTracker.API.Models;
using Microsoft.EntityFrameworkCore;

namespace KegTracker.API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Beer> Beers { get; set; }
    public DbSet<Keg> Kegs { get; set; }
    public DbSet<ConsumptionLog> ConsumptionLogs { get; set; }
}