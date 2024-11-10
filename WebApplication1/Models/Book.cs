namespace WebApplication1.Models;
using System.Collections.Generic;

public class Book
{
    public int Id { get; set; } 
    
    public string Title { get; set; } 
    
    public string Author { get; set; } 
    
    public string ISBN { get; set; } 
    
    public int CategoryId { get; set; } 
    public Category Category { get; set; } 
    
    public string Description { get; set; } 
    
    public ICollection<Tag> Tags { get; set; } 
    
    public string Excerpt { get; set; } 
    
    public BookStatus Status { get; set; } 
}

// Дополнительный enum для статусов книги
public enum BookStatus
{
    Available, // В наличии
    CheckedOut // Выдана
}
