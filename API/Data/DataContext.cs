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
    public DbSet<User> Users { get; set; }
    public DbSet<MangaCollection> MangaCollections { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // builder.Entity<Manga>()
        //   .HasOne(x => x.Id)
        //   .WithOne()
        //   .OnDelete(DeleteBehavior.Cascade);

        // builder.Entity<CoverArt>()
        //   .HasOne(x => x.Id)
        //   .WithOne()
        //   .OnDelete(DeleteBehavior.Cascade);

        // builder.Entity<MangaChapter>()
        //   .HasOne(x => x.Id)
        //   .WithOne()
        //   .OnDelete(DeleteBehavior.Cascade);

        // builder.Entity<ScanlationGroup>()
        //   .HasOne(x => x.Id)
        //   .WithOne()
        //   .OnDelete(DeleteBehavior.Cascade);

        // builder.Entity<Tag>()
        //   .HasOne(x => x.Id)
        //   .WithOne()
        //   .OnDelete(DeleteBehavior.Cascade);

        // builder.Entity<User>()
        //   .HasOne(x => x.Id)
        //   .WithOne()
        //   .OnDelete(DeleteBehavior.Cascade);
    }
  }
}