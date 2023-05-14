using Cinema.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Cinema.Views.Admin
{
    /// <summary>
    /// Interaction logic for MainAdminWindow.xaml
    /// </summary>
    public partial class MainAdminWindow : Window
    {
        DispatcherTimer timer;
        double panelWidth;
        bool hidden;


        public MainAdminWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 10);
            timer.Tick += Timer_Tick;
            panelWidth = sidePanel.Width;
            ViewModel viewModel = new ViewModel();
            DataContext = viewModel;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                sidePanel.Width -= 1;
                if(sidePanel.Width <=30)
                {
                    timer.Stop();
                    hidden =true;
                }
            }
        }
       
        public void load() {

            

        //    Products = new ObservableCollection<ViewModel>
        //{
        //    new ViewModel { ImageUrl = "product1.jpg", Name = "Product 1", Price = 10.0m },
        //    new ViewModel { ImageUrl = "product2.jpg", Name = "Product 2", Price = 15.0m },
        //    new ViewModel { ImageUrl = "product3.jpg", Name = "Product 3", Price = 20.0m },
        //    // Add more products as needed
        //};
        }
    

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
            //menu.IsEnabled = false;
        }

        //private void hideButton_Click(object sender, RoutedEventArgs e)
        //{
        //    hideButton.IsEnabled = false;
        //}

        private void panelHeader_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}
