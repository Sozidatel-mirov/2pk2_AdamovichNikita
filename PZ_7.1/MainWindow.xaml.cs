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
using System.IO;

namespace PZ_7._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MainText.FontSize == 20)
                MainText.FontSize = 25;
            else MainText.FontSize = 20;
        }

        private void Click_New(object sender, RoutedEventArgs e)
        {
            CreateFileWindow createFileWindow = new CreateFileWindow();
            if (createFileWindow.ShowDialog() == true)
            {
                File.Create(@"C:\Users\adamovich.nv1250\source\repos\PZ_7\PZ_7.1\Data\" + $"{createFileWindow.FileName}" +".txt");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (MainText.FontSize == 20)
                MainText.FontSize = 25;
            else MainText.FontSize = 20;
        }

        private void Click_Open(object sender, RoutedEventArgs e)
        {
            FileStream open = new FileStream(@"C:\Users\adamovich.nv1250\source\repos\PZ_7\PZ_7.1\Data\1.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader file = new StreamReader(open);
            MainText.AppendText(file.ReadToEnd());
            file.Close();
        }

        private void Click_Save(object sender, RoutedEventArgs e)
        {
            FileStream open = new FileStream(@"C:\Users\adamovich.nv1250\source\repos\PZ_7\PZ_7.1\Data\1.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(open);
            writer.Write("22");
            writer.Close();
        }
    }
}
