using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day1.Models
{
    public class User(string email, string name, string gender)
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; set; } = name;
        public string Gender { get; set; } = gender;
        public string Email { get; set; } = email;
    }
}
