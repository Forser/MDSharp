using System.Collections.Generic;

namespace API.Entites
{
    public class MangaCollection
    {
        public int Id { get; set; }
        public ICollection<Manga> Mangas { get; set; }
        public ICollection<MangaChapter> Chapters { get; set; }
    }
}