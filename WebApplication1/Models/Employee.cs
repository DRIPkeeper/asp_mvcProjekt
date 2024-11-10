namespace WebApplication1.Models;
using System.Collections.Generic;




    public class Employee
    {
        public int Id { get; set; } 

        public string Username { get; set; } 

        public EmployeeRole Role { get; set; } 

        public ICollection<Book> ManagedBooks { get; set; } 

        public Employee()
        {
            ManagedBooks = new List<Book>(); 
        }
    }

    
    public enum EmployeeRole
    {
        Librarian, 
        Administrator 
    }
