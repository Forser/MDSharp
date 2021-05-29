using System;
using System.Collections.Generic;
using System.Linq;
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
            var readChapters = JsonDocument.Parse(readData);
            var chaptersRead = readChapters.RootElement.EnumerateObject()
                                .Where(it => it.Value.ValueKind == JsonValueKind.Array && it.Name == "data")
                                .SelectMany(it => it.Value.EnumerateArray().Select(that => that.GetString()));

            Console.WriteLine(chaptersRead);

            var _chapters = new List<string>();
            _chapters.AddRange(chaptersRead);

            var _readChapters = new ChaptersRead();

            foreach (var _chapter in chaptersRead)
            {
                var readChapter = new ChapterId { ReadId = _chapter };
                _readChapters.Data.Add(readChapter);
            }

            await context.Mangas.AddAsync(manga);
            await context.ChaptersReads.AddRangeAsync(_readChapters);
            await context.MangaUsers.AddAsync(author);
            await context.MangaUsers.AddAsync(artist);
            await context.MangaChapters.AddAsync(chapters);
            await context.SaveChangesAsync();
        }
    }
}