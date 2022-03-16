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
            if (MainText.FontSize==20)
                MainText.FontSize = 25;
            else MainText.FontSize = 20;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (MainText.FontStyle == "Italic")
                FontStyle = "Italic";
            else MainText.FontSize = 20;
        }
    }
}
