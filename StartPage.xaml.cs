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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
            
        }
        public static int shrt;
        //private void Schrrt_TextChanged(object sender, TextChangedEventArgs e)
        //{
           
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Matrix());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            suus.NavigationService.Navigate(new Tabularinclude());
        }

        private void Button11_Click(object sender, RoutedEventArgs e)
        {
            int num;
            if (int.TryParse(Schrrt.Text,out num))
            {
                shrt = Convert.ToInt32(Schrrt.Text);
            }
            else
            {
                MessageBox.Show("Неверное значение");
            }
             
        }
    }
}
