using System;
using System.Collections.Generic;

namespace Library.UI.Entities;

public partial class Book
{
    public int BookId { get; set; }

    public string BookName { get; set; }

    public DateTime? PublicationDate { get; set; }

    public double? Price { get; set; }

    public string Author { get; set; }

    public int BookCategoryId { get; set; }
}
