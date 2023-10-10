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
    /// Логика взаимодействия для Matrix.xaml
    /// </summary>
    public partial class Matrix : Page
    {
        public Matrix()
        {
            InitializeComponent();
            for (int i = 1; i < 10; i++)
            {
                
            }


        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        public double[,] mat = new double[10, 9];
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //int sch = 0;
            //for (int i = 1; i < 11; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        sch++;
            //        var TB = (TextBox)this.FindName("df" + Convert.ToString(sch));
            //        mat[i - 1, j - 1] = Convert.ToDouble(TB.Text);
            //    }
            //}
            //double yoy = 100000;

            //int[] sij = new int[2];
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 9; j++)
            //    {
            //        if (mat[i, j] != 0 && yoy<= mat[i, j])
            //        {
            //            yoy = mat[i, j];

            //        }

            //    }
            //}
            NavigationService.Navigate(new StartPage());






        }

        private void df_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void df3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
