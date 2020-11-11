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

namespace Focsi_message
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

        private void btLogIn_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btRegistration_Click(object sender, RoutedEventArgs e)
        {
            Register_window register_Window = new Register_window();
            this.Close();
            register_Window.Show();
        }
    }
}
