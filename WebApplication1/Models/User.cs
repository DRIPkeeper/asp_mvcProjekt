namespace WebApplication1.Models;
using System.Collections.Generic;

public class User
{
    public int Id { get; set; } // Уникальный идентификатор пользователя
    
    public string Username { get; set; } // Имя пользователя
    
    public string Email { get; set; } // Электронная почта пользователя
    
    public string PasswordHash { get; set; } // Хэш пароля для безопасности
    
    public bool IsBlocked { get; set; } // Флаг блокировки
    
    public ICollection<Rental> Rentals { get; set; } // Аренды пользователя
    
    public ICollection<Reservation> Reservations { get; set; } // Резервы пользователя
    
    public ICollection<SearchHistory> SearchHistory { get; set; } // История поисков
}
