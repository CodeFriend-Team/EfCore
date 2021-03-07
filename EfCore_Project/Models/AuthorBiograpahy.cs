using System;

namespace EfCore_Project.Models
{
    public class AuthorBiograpahy
    {
        public int Id { get; set; }
        public string Biography { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsAlive { get; set; }
        public string PlaceOfLiving { get; set; }
        public int Age { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
