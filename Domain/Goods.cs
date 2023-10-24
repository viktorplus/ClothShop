using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6.Domain
{
    public class Goods : INotifyPropertyChanged
    {
        public int itemId;
        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; NotifyPropertyChanged("ItemId"); }
        }
        public string photo;
        public string Photo
        {
            get { return photo; }
            set { photo = value; NotifyPropertyChanged("Photo"); }
        }
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; NotifyPropertyChanged("Name"); }
        }
        public string description;
        public string Description
        {
            get { return description; }
            set { description = value; NotifyPropertyChanged("Description"); }
        }
        public string color;
        public string Color
        {
            get { return color; }
            set { color = value; NotifyPropertyChanged("Color"); }
        }
        public string size;
        public string Size
        {
            get { return size; }
            set { size = value; NotifyPropertyChanged("Size"); }
        }
        public int count;
        public int Count
        {
            get { return count; }
            set { count = value; NotifyPropertyChanged("Count"); }
        }
        public float price;
        public float Price
        {
            get { return price; }
            set { price = value; NotifyPropertyChanged("Price"); }
        }
        public DateTime dateAdded;
        public DateTime DateAdded
        {
            get { return dateAdded; }
            set { dateAdded = value; NotifyPropertyChanged("DateAdded"); }
        }

        public Goods(int itemId, string photo, string name, string description, string color, string size, int count, float price, DateTime dateAdded)
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

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}