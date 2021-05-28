using System;
using System.Text.Json;
using System.Threading.Tasks;
using API.Entites;

namespace API.Data
{
  public class SeedManga
    {
        public static async Task MangaSeeder(DataContext context)
        {
            var mangaData = await System.IO.File.ReadAllTextAsync("../JSON Data/SoloLeveling.json");
            var manga = JsonSerializer.Deserialize<Manga>(mangaData);

            if (manga == null) return;

            var authorData = await System.IO.File.ReadAllTextAsync("../JSON Data/AuthorSoloLeveling.json");
            var author = JsonSerializer.Deserialize<MangaUser>(authorData);

            var artistData = await System.IO.File.ReadAllTextAsync("../JSON Data/ArtistSoloLeveling.json");
            var artist = JsonSerializer.Deserialize<MangaUser>(artistData);

            var chapterData = await System.IO.File.ReadAllTextAsync("../JSON Data/ChaptersForSoloLeveling.json");
            var chapters = JsonSerializer.Deserialize<MangaChapters>(chapterData);

            var readData = await System.IO.File.ReadAllTextAsync("../JSON Data/SoloLevelingChaptersRead.json");
            var readChapters = JsonSerializer.Deserialize<ChaptersRead>(readData);

            Console.WriteLine(chapters);

            await context.Mangas.AddAsync(manga);
            await context.ChaptersReads.AddAsync(readChapters);
            await context.MangaUsers.AddAsync(author);
            await context.MangaUsers.AddAsync(artist);
            await context.MangaChapters.AddAsync(chapters);
            await context.SaveChangesAsync();
        }
    }
}