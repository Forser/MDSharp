using System.Collections.Generic;

namespace API.Entites
{
    public class MangaCollection
    {
        public int Id { get; set; }
        public List<Manga> Mangas { get; set; } = new List<Manga>();
        public List<MangaChapter> Chapters { get; set; } = new List<MangaChapter>();
    }
}