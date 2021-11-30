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

namespace Kontrolki3a
{
    /// <summary>
    /// Logika interakcji dla klasy KwadratWindow.xaml
    /// </summary>
    public partial class KwadratWindow : Window
    {
        public KwadratWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double bok;
            if(double.TryParse(textBox.Text, out bok))
            {
                double pole = Math.Pow(bok, 2.0);

            }  
        }
    }
}
