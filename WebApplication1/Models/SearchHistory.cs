namespace WebApplication1.Models;
using System;

public class SearchHistory
{
    public int Id { get; set; } 
    
    public int UserId { get; set; } 
    public User User { get; set; } 
    
    public string SearchQuery { get; set; } 
    
    public DateTime SearchDate { get; set; } 
    
    public ICollection<Book> Results { get; set; } 
}
