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

namespace WPFMDK01Sesian2.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientsPage.xaml
    /// </summary>
    public partial class ClientsPage : Page
    {
        public ClientsPage()
        {
            InitializeComponent();
            dgSubscribers.ItemsSource = BaseClass.ep.Clients.ToList();
            Active.IsChecked = true; // По умолчанию выводятся абоненты с активными договорами
            //List<Raions> raions = Base.baseDate.Raions.ToList(); // Заполнение списка районов
            //cbFilterRaion.Items.Add("Все районы");
            //foreach (Raions raion in raions)
            //{
            //    cbFilterRaion.Items.Add(raion.RaionName);
            //}
            //cbFilterRaion.SelectedIndex = 0;
            //cbFilterStreet.IsEnabled = false;
            //cbFiltNomerHouse.IsEnabled = false;
        }

        private void Active_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NotActive_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
