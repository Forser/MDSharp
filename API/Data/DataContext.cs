using System;
using System.Collections.Generic;
using System.Linq;
using API.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Text.Json;

namespace API.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Manga> Mangas { get; set; }
    public DbSet<MangaChapters> MangaChapters { get; set; }
    //public DbSet<ChaptersRead> ChaptersReads { get; set; }
    public DbSet<CoverArt> CoverArts { get; set; }
    public DbSet<ScanlationGroup> ScanlationGroups { get; set; }
    public DbSet<MangaUser> MangaUsers { get; set; }
    // public DbSet<MangaCollection> MangaCollections { get; set; }

    // public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // builder.Entity<ChaptersRead>()
        //   .Property(e => e.Data)
        //   .HasConversion(
        //     v => JsonSerializer.Serialize(v, null),
        //     v => JsonSerializer.Deserialize<List<string>>(v, null),
        //     new ValueComparer<IList<string>>(
        //       (c1, c2) => c1.SequenceEqual(c2),
        //       c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
        //       c => (IList<string>)c.ToList()
        //     )
        //   );

        // builder.Entity<Manga>()
        //   .OwnsMany(p => p.relationship, a => {
        //     a.WithOwner().HasForeignKey("Id");
        //     a.Property<int>("Id");
        //     a.HasKey("Id");
        //   });

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