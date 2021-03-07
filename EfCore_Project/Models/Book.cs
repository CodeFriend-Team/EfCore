using System.Collections.Generic;
namespace EfCore_Project.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }
}
