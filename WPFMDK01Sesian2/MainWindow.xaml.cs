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
using WPFMDK01Sesian2.Class;
using WPFMDK01Sesian2.Pages;

namespace WPFMDK01Sesian2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BaseClass.ep = new EP2();
            FrameClass.frame = frame;
            FrameClass.frame.Navigate(new ClientsPage());
            cbEmp.ItemsSource = BaseClass.ep.Emploe.ToList();
            cbEmp.DisplayMemberPath = "Surname";
            cbEmp.SelectedValuePath = "IDEmploys";
            cbEmp.SelectedIndex = 0;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CRM_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAbon_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
