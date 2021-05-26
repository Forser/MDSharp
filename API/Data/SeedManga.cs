using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using API.Entites;

namespace API.Data
{
    public class SeedManga
    {
        public static async Task MangaSeeder()
        {
            var mangaData = await System.IO.File.ReadAllTextAsync("../JSON Data/SoloLeveling.json");
            var manga = JsonSerializer.Deserialize<Manga>(mangaData);

            Console.WriteLine($"Result: {manga}");
            Console.WriteLine("Hello World");
        }
    }
}