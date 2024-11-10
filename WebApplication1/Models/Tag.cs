namespace WebApplication1.Models;
using System.Collections.Generic;

public class Tag
{
    public int Id { get; set; } // Уникальный идентификатор тега
    
    public string Name { get; set; } // Название тега
    
    public ICollection<Book> Books { get; set; } // Книги, связанные с этим тегом
}
