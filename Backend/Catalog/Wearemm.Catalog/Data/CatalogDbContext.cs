using Microsoft.EntityFrameworkCore;
using Wearemm.Catalog.Entities;

namespace Wearemm.Catalog.Database;

public class CatalogDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Artist> Artists => Set<Artist>();
    public DbSet<Album> Albums => Set<Album>();
    public DbSet<Genre> Genres => Set<Genre>();
    public DbSet<Track> Tracks => Set<Track>();
}
