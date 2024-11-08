
using Prevdent.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Prevdent.Infraestructure.Data.AppData;

public class ApplicationContext : DbContext
{
    public DbSet<DentistaEntity> Dentistas { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}
