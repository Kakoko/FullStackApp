using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStack.Data.Models
{
    public class Employee
    {
        public int Id { get; set; }// primary key
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Position { get; set; }
        public DateTime DateHired { get; set; }
    }
}
