using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6.Domain
{
    public class Gud
    {
        public int ItemId { get; set; }
        public string Photo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public DateTime DateAdded { get; set; }

        public Gud(int itemId, string photo, string name, string description, string color, string size, int count, decimal price, DateTime dateAdded)
        {
            ItemId = itemId;
            Photo = photo;
            Name = name;
            Description = description;
            Color = color;
            Size = size;
            Count = count;
            Price = price;
            DateAdded = dateAdded;
        }
    }
}
