using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Security.AccessControl;
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
    /// Логика взаимодействия для Creation.xaml
    /// </summary>
    public partial class Creation : Page
    {

        public Creation()
        {
            InitializeComponent();


        }

        public int id = 1;
        public double[,] Houses = new double[2, StartPage.shrt];
        public int gg = 0;
        private void addL(object sender, MouseButtonEventArgs e)
        {
            if (id <= StartPage.shrt)
            {
                if (id == 1)
                {
                    Ellipse newRec = new Ellipse
                    {
                        Width = 50,
                        Height = 50,
                        StrokeThickness = 3,
                        Fill = Brushes.Brown,
                        Stroke = Brushes.Yellow
                    };
                    Canvas.SetLeft(newRec, Mouse.GetPosition(MyCanvas).X);
                    Canvas.SetTop(newRec, Mouse.GetPosition(MyCanvas).Y);
                    MyCanvas.Children.Add(newRec);

                }
                else
                {
                    Rectangle newRec = new Rectangle
                    {
                        Width = 50,
                        Height = 50,
                        StrokeThickness = 3,
                        Fill = Brushes.Brown,
                        Stroke = Brushes.Black
                    };
                    Canvas.SetLeft(newRec, Mouse.GetPosition(MyCanvas).X);
                    Canvas.SetTop(newRec, Mouse.GetPosition(MyCanvas).Y);
                    MyCanvas.Children.Add(newRec);

                }
                TextBlock tb = new TextBlock
                {
                    Width = 50,
                    Height = 50,
                    Text = Convert.ToString(id),

                    TextAlignment = TextAlignment.Center,
                    FontSize = 15
                };
                Canvas.SetLeft(tb, Mouse.GetPosition(MyCanvas).X);
                Canvas.SetTop(tb, Mouse.GetPosition(MyCanvas).Y + 15);
                Houses[0, id - 1] = Mouse.GetPosition(MyCanvas).X + 15;
                Houses[1, id - 1] = Mouse.GetPosition(MyCanvas).Y + 15;
                MyCanvas.Children.Add(tb);
                id++;
            }
            else
            {
                MessageBox.Show($"Максимальный лимит домов уже добавлен: {id - 1}");
            }
        }
        public int clickL = 0;

        private void addD(object sender, MouseButtonEventArgs e)
        {
            if (id <= StartPage.shrt)
            {
                MessageBox.Show("Не все дома пострены");
            }
            else
            {


                if (clickL == 0)
                {
                    MyCanvas.Children.Clear();
                    for (int i = 0; i < Tabularinclude.Datas1.Count; i++)
                    {
                        Line newRe1c = new Line
                        {

                            X1 = Convert.ToInt32(Houses[0, Convert.ToInt32(Tabularinclude.Datas1[i].ind1) - 1] + 25),
                            X2 = Convert.ToInt32(Houses[0, Convert.ToInt32(Tabularinclude.Datas1[i].ind2) - 1] + 25),
                            Y1 = Convert.ToInt32(Houses[1, Convert.ToInt32(Tabularinclude.Datas1[i].ind1) - 1] + 10),
                            Y2 = Convert.ToInt32(Houses[1, Convert.ToInt32(Tabularinclude.Datas1[i].ind2) - 1] + 10),
                            Stroke = Brushes.Gold,
                            Fill = Brushes.Brown,
                            StrokeThickness = 4,

                        };
                        MyCanvas.Children.Add(newRe1c);
                        TextBlock tb2 = new TextBlock
                        {
                            Width = 20,
                            Height = 20,
                            Text = Convert.ToString(Tabularinclude.Datas1[i].pathsize),
                            Background = Brushes.Gold,
                            TextAlignment = TextAlignment.Center,
                            FontSize = 15
                        };
                     
                        int jj = Convert.ToInt32(Houses[0, Convert.ToInt32(Tabularinclude.Datas1[i].ind1) - 1] + 25);

                        int kk = Convert.ToInt32(Houses[0, Convert.ToInt32(Tabularinclude.Datas1[i].ind2) - 1] + 25);
                        int uu = Convert.ToInt32(Houses[1, Convert.ToInt32(Tabularinclude.Datas1[i].ind1) - 1] + 10);
                        int mm = Convert.ToInt32(Houses[1, Convert.ToInt32(Tabularinclude.Datas1[i].ind2) - 1] + 10);



                        Canvas.SetTop(tb2, (mm + uu) / 2);
                            int gdfjdfgnjdfghnjd = (mm + uu) / 2;



                            Canvas.SetLeft(tb2, (kk + jj) / 2);
                            int gdfjdfgnjdfghnjd12 = (kk + jj) / 2;







                        MyCanvas.Children.Add(tb2);

                    }























                    Ellipse newRec = new Ellipse
                    {
                        Width = 50,
                        Height = 50,
                        StrokeThickness = 3,
                        Fill = Brushes.Brown,
                        Stroke = Brushes.Yellow
                    };
                    Canvas.SetLeft(newRec, Houses[0, 0] - 15);
                    Canvas.SetTop(newRec, Houses[1, 0] - 15);
                    MyCanvas.Children.Add(newRec);

                    for (int i = 0; i < Tabularinclude.Datasgo.Count; i++)
                    {
                        if (i != 0)
                        {
                            Rectangle new1Rec = new Rectangle
                            {
                                Width = 50,
                                Height = 50,
                                StrokeThickness = 3,
                                Fill = Brushes.Brown,
                                Stroke = Brushes.Black
                            };
                            Canvas.SetLeft(new1Rec, Houses[0, i] - 15);
                            Canvas.SetTop(new1Rec, Houses[1, i] - 15);
                            MyCanvas.Children.Add(new1Rec);
                        }

                        Rectangle new2Rec = new Rectangle
                        {
                            Width = 50,
                            Height = 50,
                            StrokeThickness = 3,
                            Fill = Brushes.Brown,
                            Stroke = Brushes.Black
                        };
                        Canvas.SetLeft(new2Rec, Houses[0, i + 1] - 15);
                        Canvas.SetTop(new2Rec, Houses[1, i + 1] - 15);
                        MyCanvas.Children.Add(new2Rec);

                        TextBlock tb1 = new TextBlock
                        {
                            Width = 50,
                            Height = 50,
                            Text = Convert.ToString(i + 1),

                            TextAlignment = TextAlignment.Center,
                            FontSize = 15
                        };
                        Canvas.SetLeft(tb1, Houses[0, i] - 15);
                        Canvas.SetTop(tb1, Houses[1, i]);
                        MyCanvas.Children.Add(tb1);

                        TextBlock tb2 = new TextBlock
                        {
                            Width = 50,
                            Height = 50,
                            Text = Convert.ToString(i + 2),

                            TextAlignment = TextAlignment.Center,
                            FontSize = 15
                        };
                        Canvas.SetLeft(tb2, Houses[0, i + 1] - 15);
                        Canvas.SetTop(tb2, Houses[1, i + 1]);
                        MyCanvas.Children.Add(tb2);

                    }
                    clickL++;
                }
                else
                {
                    MyCanvas.Children.Clear();


                    for (int i = 0; i < Tabularinclude.Datasgo.Count; i++)
                    {
                        Line newRe1c = new Line
                        {

                            X1 = Convert.ToInt32(Houses[0, Convert.ToInt32(Tabularinclude.Datasgo[i].ind1) - 1] + 25),
                            X2 = Convert.ToInt32(Houses[0, Convert.ToInt32(Tabularinclude.Datasgo[i].ind2) - 1] + 25),
                            Y1 = Convert.ToInt32(Houses[1, Convert.ToInt32(Tabularinclude.Datasgo[i].ind1) - 1] + 10),
                            Y2 = Convert.ToInt32(Houses[1, Convert.ToInt32(Tabularinclude.Datasgo[i].ind2) - 1] + 10),
                            Stroke = Brushes.Gold,
                            Fill = Brushes.Brown,
                            StrokeThickness = 4,

                        };
                        MyCanvas.Children.Add(newRe1c);
                        TextBlock tb2 = new TextBlock
                        {
                            Width = 20,
                            Height = 20,
                            Text = Convert.ToString(Tabularinclude.Datasgo[i].pathsize),
                            Background = Brushes.Gold,
                            TextAlignment = TextAlignment.Center,
                            FontSize = 15
                        };
                    
                        int jj = Convert.ToInt32(Houses[0, Convert.ToInt32(Tabularinclude.Datasgo[i].ind1) - 1] + 25);

                        int kk = Convert.ToInt32(Houses[0, Convert.ToInt32(Tabularinclude.Datasgo[i].ind2) - 1] + 25);
                        int uu = Convert.ToInt32(Houses[1, Convert.ToInt32(Tabularinclude.Datasgo[i].ind1) - 1] + 10);
                        int mm = Convert.ToInt32(Houses[1, Convert.ToInt32(Tabularinclude.Datasgo[i].ind2) - 1] + 10);



                        Canvas.SetTop(tb2, (mm + uu) / 2);
                        int gdfjdfgnjdfghnjd = (mm + uu) / 2;



                        Canvas.SetLeft(tb2, (kk + jj) / 2);
                        int gdfjdfgnjdfghnjd12 = (kk + jj) / 2;







                        MyCanvas.Children.Add(tb2);
                    }























                    Ellipse newRec = new Ellipse
                    {
                        Width = 50,
                        Height = 50,
                        StrokeThickness = 3,
                        Fill = Brushes.Brown,
                        Stroke = Brushes.Yellow
                    };
                    Canvas.SetLeft(newRec, Houses[0, 0] - 15);
                    Canvas.SetTop(newRec, Houses[1, 0] - 15);
                    MyCanvas.Children.Add(newRec);

                    for (int i = 0; i < Tabularinclude.Datasgo.Count; i++)
                    {
                        if (i != 0)
                        {
                            Rectangle new1Rec = new Rectangle
                            {
                                Width = 50,
                                Height = 50,
                                StrokeThickness = 3,
                                Fill = Brushes.Brown,
                                Stroke = Brushes.Black
                            };
                            Canvas.SetLeft(new1Rec, Houses[0, i] - 15);
                            Canvas.SetTop(new1Rec, Houses[1, i] - 15);
                            MyCanvas.Children.Add(new1Rec);
                        }

                        Rectangle new2Rec = new Rectangle
                        {
                            Width = 50,
                            Height = 50,
                            StrokeThickness = 3,
                            Fill = Brushes.Brown,
                            Stroke = Brushes.Black
                        };
                        Canvas.SetLeft(new2Rec, Houses[0, i + 1] - 15);
                        Canvas.SetTop(new2Rec, Houses[1, i + 1] - 15);
                        MyCanvas.Children.Add(new2Rec);

                        TextBlock tb1 = new TextBlock
                        {
                            Width = 50,
                            Height = 50,
                            Text = Convert.ToString(i + 1),

                            TextAlignment = TextAlignment.Center,
                            FontSize = 15
                        };
                        Canvas.SetLeft(tb1, Houses[0, i] - 15);
                        Canvas.SetTop(tb1, Houses[1, i]);
                        MyCanvas.Children.Add(tb1);

                        TextBlock tb2 = new TextBlock
                        {
                            Width = 50,
                            Height = 50,
                            Text = Convert.ToString(i + 2),

                            TextAlignment = TextAlignment.Center,
                            FontSize = 15
                        };
                        Canvas.SetLeft(tb2, Houses[0, i + 1] - 15);
                        Canvas.SetTop(tb2, Houses[1, i + 1]);
                        MyCanvas.Children.Add(tb2);

                    }

                    clickL--;
                }
                

            }
        }
    }
}
