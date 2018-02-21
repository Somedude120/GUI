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

namespace WPF_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Sailboat obj = new Sailboat();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HullSpeedBox.Text = obj.Hullspeed().ToString();
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            obj.Name = NameTextBox.Text;
        }

        private void LengthBox_LostFocus(object sender, RoutedEventArgs e)
        {
            obj.Length = Convert.ToDouble(LengthBox.Text);
        }
    }
}
