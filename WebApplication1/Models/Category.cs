namespace WebApplication1.Models;
using System.Collections.Generic;

public class Category
{
    public int Id { get; set; } 
    
    public string Name { get; set; } 
    
    public int? ParentCategoryId { get; set; } 
    public Category ParentCategory { get; set; } 
    
    public ICollection<Book> Books { get; set; } 
}
