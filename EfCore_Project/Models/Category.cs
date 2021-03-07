﻿using System.Collections.Generic;

namespace EfCore_Project.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }
}
