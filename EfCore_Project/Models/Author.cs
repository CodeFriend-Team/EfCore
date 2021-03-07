namespace EfCore_Project.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AuthorBiograpahy AuthorBiograpahy { get; set; }
    }
}
