using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Excel = Microsoft.Office.Interop.Excel;



namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для Tabularinclude.xaml
    /// </summary>
    public partial class Tabularinclude : Page
    {
        public Tabularinclude()
        {
            InitializeComponent();
            bt1_Copy.Visibility = Visibility.Hidden;
            bt1.Visibility = Visibility.Visible;
            cb1.Items.Clear();
            cb2.Items.Clear();
            TBshow.Text = "";
            Datasgo.Clear();
            Datas.Clear();
            Datas1.Clear();
            StartPage startPage = new StartPage();
            int comb = StartPage.shrt;
            if (comb == 0)
            {
                comb = 10;
                StartPage.shrt = 10;
            }
            for (int i = 1; i <= comb; i++)
            {
                cb1.Items.Add(i);
                cb2.Items.Add(i);
            }
        }
        public class datas
        {
            public string ind1 { get; set; }
            public string ind2 { get; set; }
            public double pathsize { get; set; }

        }
        public static List<datas> Datas = new List<datas>();
        public static List<datas> Datas1 = new List<datas>();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //List<string> list = new List<string>();
                //if (cb1 == null && cb2 == null)
                //{

                //    SaveFileDialog saveFileDialog = new SaveFileDialog();
                //    saveFileDialog.Filter = "Text Files(*.txt)|*.txt";
                //    if (saveFileDialog.ShowDialog() == true)
                //    {
                //        string TxtRead;
                //        using (StreamReader reader = new StreamReader(saveFileDialog.FileName))
                //        {
                //            TxtRead = reader.ReadToEnd();
                //        }
                //        TxtRead.Replace(" => ", " ").Replace("----"," ").Replace(" || "," ");
                //        list = TxtRead.Split(' ');


                //    }
                //}

                if (cb1.Text != cb2.Text)
                {
                    var ind = Datas.Where(x => x.ind1 == cb1.Text && x.ind2 == cb2.Text).ToList();
                    if (ind.Count < 1)
                    {
                        var ind2 = Datas.Where(x => x.ind2 == cb1.Text && x.ind1 == cb2.Text).ToList();
                        if (ind2.Count < 1)
                        {

                            TBshow.Text += cb1.Text + "=>" + cb2.Text + "----" + TBsize.Text + " || ";
                            Datas.Add(new datas { ind1 = cb1.Text, ind2 = cb2.Text, pathsize = Convert.ToDouble(TBsize.Text) });
                            Datas1.Add(new datas { ind1 = cb1.Text, ind2 = cb2.Text, pathsize = Convert.ToDouble(TBsize.Text) });
                        }
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("Такой путь уже существует");
                    }




                }
                else
                {
                    System.Windows.MessageBox.Show("Такой путь не доступен по техническим причинам. Попробуйте завтра");
                }
            }
            catch
            {

            }
        }

        private void cb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TBshow.Text = "";
            Datasgo.Clear();
            Datas.Clear();
            Datas1.Clear();
        }
        public class datasgo
        {
            public string ind1 { get; set; }
            public string ind2 { get; set; }
            public double pathsize { get; set; }

        }
        public static List<datas> Datasgo = new List<datas>();
        public static List<datas> Datasgo1 = new List<datas>();
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
            string[] unblocked = new string[StartPage.shrt - 1];
            unblocked[0] = "1";
            int unlockedScore = 1;
            for (int i = 0; i < StartPage.shrt - 1; i++)
            {
                double yoy = 11111111;
                string id1 = "";
                string id2 = "";

                for (int j = 0; j < unlockedScore; j++)
                {
                    var ind = Datas.Where(x => x.ind1 == Convert.ToString(unblocked[j]) || x.ind2 == Convert.ToString(unblocked[j])).ToList();
                    for (int l = 0; l < ind.Count; l++)
                    {
                        if (ind[l].ind1 == "5"&& ind[l].ind2 == "6")
                        {

                        }
                        if (ind[l].ind1 == "5" && ind[l].ind2 == "3")
                        {

                        }
                        if (ind[l].ind1 == "5" && ind[l].ind2 == "7")
                        {

                        }
                        if (!unblocked.Contains($"{ind[l].ind1}") || !unblocked.Contains($"{ind[l].ind2}"))
                        {
                            if (ind[l].pathsize < yoy)
                            {
                                yoy = ind[l].pathsize;
                                id1 = ind[l].ind1;
                                id2 = ind[l].ind2;
                            }
                        }
                    }
                    //5 5 4 6 4 8
                }
                if (i != StartPage.shrt - 2)
                {
                    unlockedScore++;
                    if (!unblocked.Contains($"{id2}"))
                    {
                        unblocked[i + 1] = id2;
                    }
                    if (!unblocked.Contains($"{id1}"))
                    {
                        unblocked[i + 1] = id1;
                    }
                }

                Datasgo.Add(new datas { ind1 = id1, ind2 = id2, pathsize = yoy });
                var sus = Datas.RemoveAll(x => x.ind1 == id1 && x.ind2 == id2);

            }
            double summ = 0;
            TBshow.Text = "";
            for (int i = 0; i < Datasgo.Count; i++)
            {
                summ += Datasgo[i].pathsize;
                TBshow.Text += Datasgo[i].ind1 + "=>" + Datasgo[i].ind2 + "----" + Datasgo[i].pathsize + " || ";
            }
            Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            saveFileDialog.Filter = "Text Files(*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == true)
            {
                string TxtRead;
                using (StreamReader reader = new StreamReader(saveFileDialog.FileName))
                {
                    TxtRead = reader.ReadToEnd();
                }



                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.WriteLine(TxtRead);
                    for (int i = 0; i < Datasgo.Count; i++)
                    {

                        writer.WriteLine(Datasgo[i].ind1 + " => " + Datasgo[i].ind2 + " ---- " + Datasgo[i].pathsize + " || ");
                    }
                    writer.WriteLine("Сумма путей => " + summ.ToString());
                    writer.Write("========================");
                }
            }
            

                TBshow.Text += "\n\n" + Convert.ToString(summ);
            bt1.Visibility = Visibility.Hidden;
            bt1_Copy.Visibility = Visibility.Visible;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            HUH.NavigationService.Navigate(new Creation());
        }

        private void Button1_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                string files = "";
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        files = fbd.SelectedPath;
                    }
                }


                Excel.Application xlApp = new Excel.Application();

                Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(files, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); // 1 секунда
                Excel.Worksheet sheet = (Excel.Worksheet)xlWorkBook.Sheets[1];
                int y = 0;
                string[,] mas1 = new string[3, 100];

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 100; j++)
                    {
                        try
                        {
                            if (sheet.Cells[i][j].Value2 != null && sheet.Cells[i][j].Value2 != "")
                            {
                                mas1[i, j] = sheet.Cells[i][j].Value2;
                                y++;
                            }
                        }
                        catch { }


                    }
                    y = 0;
                }





                for (int i = 0; i < y; i++)
                {
                    cb1.Text = mas1[0, i];
                    cb2.Text = mas1[1, i];
                    TBsize.Text = mas1[2, i];



                    if (cb1.Text != cb2.Text)
                    {

                        var ind = Datas.Where(x => x.ind1 == cb1.Text && x.ind2 == cb2.Text).ToList();
                        if (ind.Count < 1)
                        {
                            var ind2 = Datas.Where(x => x.ind2 == cb1.Text && x.ind1 == cb2.Text).ToList();
                            if (ind2.Count < 1)
                            {

                                TBshow.Text += cb1.Text + "=>" + cb2.Text + "----" + TBsize.Text + " || ";
                                Datas.Add(new datas { ind1 = cb1.Text, ind2 = cb2.Text, pathsize = Convert.ToDouble(TBsize.Text) });
                                Datas1.Add(new datas { ind1 = cb1.Text, ind2 = cb2.Text, pathsize = Convert.ToDouble(TBsize.Text) });
                            }
                        }
                        else
                        {
                            System.Windows.MessageBox.Show("Такой путь уже существует");
                        }




                    }
                    else
                    {
                        System.Windows.MessageBox.Show("Такой путь не доступен по техническим причинам. Попробуйте завтра");
                    }
                }
            }
            catch
            {

            }
        }
        }
    }
