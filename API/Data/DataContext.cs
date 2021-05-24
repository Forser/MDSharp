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
    public DbSet<CoverArt> CoverArts { get; set; }
    public DbSet<MangaChapter> MangaChapters { get; set; }
    public DbSet<ScanlationGroup> ScanlationGroups { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);


    }
  }
}