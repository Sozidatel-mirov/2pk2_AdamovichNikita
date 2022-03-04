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
using System.Text.RegularExpressions;

namespace PZ_Calculatator
{
    public partial class MainWindow : Window
    {
        private static string expression;
        public MainWindow()
        {   
        }
        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            AUG.Text += Button7.Content;
            expression += Button7.Content;
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            AUG.Text += Button8.Content;
            expression += Button8.Content;
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            AUG.Text += Button9.Content;
            expression += Button9.Content;
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            AUG.Text += ButtonPlus.Content;
            expression += ButtonPlus.Content;
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            AUG.Text += Button4.Content;
            expression += Button4.Content;
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            AUG.Text += Button5.Content;
            expression += Button5.Content;
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            AUG.Text += Button6.Content;
            expression += Button6.Content;
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            AUG.Text += ButtonMinus.Content;
            expression += ButtonMinus.Content;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            AUG.Text += Button1.Content;
            expression += Button1.Content;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            AUG.Text += Button2.Content;
            expression += Button2.Content;
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            AUG.Text += Button3.Content;
            expression += Button3.Content;
        }

        private void ButtonUmnojit_Click(object sender, RoutedEventArgs e)
        {
            AUG.Text += "*";
            expression += "*";
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            AUG.Text += Button0.Content;
            expression += Button0.Content;
        }

        private void ButtonDelit_Click(object sender, RoutedEventArgs e)
        {
            AUG.Text += ButtonDelit.Content;
            expression += ButtonDelit.Content;
        }

        private void ButtonRavno_Click(object sender, RoutedEventArgs e)
        {
            Regex r = new Regex(@"[\-\+\*\/]+");
            Match tel = r.Match(expression);
            string znak = "0";
            while (tel.Success)
            {
                znak = Convert.ToString(tel);
                tel = tel.NextMatch();
            }
            string text = expression;
            string[] newText = Regex.Split(text, "[-+*/]+");
            if (znak == "+")
                AUG.Text = $"{Convert.ToString(Convert.ToDouble(newText[0]) + Convert.ToDouble(newText[1]))}";
            else if (znak == "-")
                AUG.Text = $"{Convert.ToString(Convert.ToDouble(newText[0]) - Convert.ToDouble(newText[1]))}";
            else if (znak == "*")
                AUG.Text = $"{Convert.ToString(Convert.ToDouble(newText[0]) * Convert.ToDouble(newText[1]))}";
            else if (znak == "/")
                AUG.Text = $"{Convert.ToString(Convert.ToDouble(newText[0]) / Convert.ToDouble(newText[1]))}";
            else
                AUG.Text = "ERROR";
        }
    }
}
