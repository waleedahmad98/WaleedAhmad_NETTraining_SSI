using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day1.Models
{
    public class Book(string isbn, string name, int quantity)
    {
        public string Isbn { get; } = isbn;
        public string Name { get; set; } = name;
        public int Quantity { get; set; } = quantity;
    }
}
