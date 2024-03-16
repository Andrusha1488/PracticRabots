using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using LRpractic1.BurgerPlaceDataSet2TableAdapters;

namespace LRpractic1
{
    public partial class MainWindow : Window
    {
        Customer_rusTableAdapter customer_rus = new Customer_rusTableAdapter();
        Orders_rusTableAdapter orders_rus = new Orders_rusTableAdapter();
    private void PreviousTable_Click(object sender, RoutedEventArgs e)
    {
        Customer_rusDataGrid.Visibility = Visibility.Visible;
        Orders_rusDataGrid.Visibility = Visibility.Collapsed;
    }

    private void NextTable_Click(object sender, RoutedEventArgs e)
    {
        Customer_rusDataGrid.Visibility = Visibility.Collapsed;
        Orders_rusDataGrid.Visibility = Visibility.Visible;
    }
        public MainWindow()
        {
            InitializeComponent();
            Customer_rusDataGrid.ItemsSource = customer_rus.GetData();
            Orders_rusDataGrid.ItemsSource = orders_rus.GetData();
        }
    }
}
