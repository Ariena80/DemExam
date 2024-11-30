using Demex2._0.Model;
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
using System.Windows.Shapes;

namespace Demex2._0
{
    /// <summary>
    /// Логика взаимодействия для AdminOrderWindow.xaml
    /// </summary>
    public partial class AdminOrderWindow : Window
    {
        private string[] models = new Base().models;
        private string[] types = new Base().types;
        private string[] deffects = new Base().deffects;
        private string[] statuses = new Base().statuses;
        private string[] priorityes = new Base().priorityes;

        private List<Order> _orders = new List<Order>();
        public AdminOrderWindow()
        {
            InitializeComponent(); for (int i = 0; i < 20; i++)
            {
                Order newOrder = new Order
                {
                    Id = i,
                    Model = models[i % 4],
                    Type = types[i % 4],
                    Deffect = deffects[i % 4],
                    Comment = "вправпра",
                    ClientName = "арвыоларолыв",
                    Status = statuses[i % 4],

                };

                _orders.Add(newOrder);
            }
            dataGrid.ItemsSource = _orders;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
