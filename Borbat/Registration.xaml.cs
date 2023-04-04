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

namespace Borbat
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void FirstPasswordPB_GotFocus(object sender, RoutedEventArgs e)
        {
            EnterPasswordLabel.Visibility = Visibility.Hidden;
            EnterPasswordLabel.IsEnabled= false;
        }

        private void EnterPasswordLabel_GotFocus(object sender, RoutedEventArgs e)
        {
            FirstPasswordPB.Focus();
        }

        private void FirstPasswordPB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (FirstPasswordPB.Password.Length == 0)
            {
                EnterPasswordLabel.Visibility = Visibility.Visible;
                EnterPasswordLabel.IsEnabled = true;
            }
        }

        private void EnterPasswordLabel_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void EnterPasswordLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            FirstPasswordPB.Focus();
        }
    }
}
