using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class Product : INotifyPropertyChanged
    {
        private string _imageUrl;
        private string _name;
        private decimal _price;

        public string ImageUrl
        {
            get { return _imageUrl; }
            set
            {
                _imageUrl = value;
                OnPropertyChanged(nameof(ImageUrl));
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public decimal Price
        {
            get { return _price; }
            set
            {
                _price = value;
                OnPropertyChanged(nameof(Price));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class ViewModel
    {
        public ObservableCollection<Product> Products { get; }

        public ViewModel()
        {
            // Populate the Products collection with sample data
            Products = new ObservableCollection<Product>
            {
                new Product { ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSnR9QkYiPQFCZG2WJ4PPxRBoNFR8fdcitnvg&usqp=CAU", Name = "Product 1", Price = 10.0m },
                new Product { ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSnR9QkYiPQFCZG2WJ4PPxRBoNFR8fdcitnvg&usqp=CAU", Name = "Product 2", Price = 15.0m },
                new Product { ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSnR9QkYiPQFCZG2WJ4PPxRBoNFR8fdcitnvg&usqp=CAU", Name = "Product 3", Price = 20.0m },
                // Add more products as needed
            };
        }
    }
}
