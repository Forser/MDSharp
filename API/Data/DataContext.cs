using API.Entites;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Manga> Mangas { get; set; }
    public DbSet<MangaCollection> MangaCollection { get; set; }
    public DbSet<MangaChapters> MangaChapters { get; set; }
    public DbSet<ChaptersRead> ChaptersReads { get; set; }
    public DbSet<CoverArt> CoverArts { get; set; }
    public DbSet<ScanlationGroup> ScanlationGroups { get; set; }
    public DbSet<MangaUser> MangaUsers { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
  }
}