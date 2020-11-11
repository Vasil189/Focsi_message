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

namespace Focsi_message
{
    /// <summary>
    /// Interaction logic for Register_window.xaml
    /// </summary>
    public partial class Register_window : Window
    {
        public Register_window()
        {
            InitializeComponent();
        }

        private void btback_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            this.Close();
            window.Show();
        }

        private void btRegister_Click(object sender, RoutedEventArgs e)
        {
            Activation_window activation_Window = new Activation_window();
            this.Close();
            activation_Window.Show();
        }
    }
}
