using System.Configuration;
using System.IO.Packaging;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Loginattempt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Exiterr.Visibility = Visibility.Hidden;
            
            
            
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void exit_MouseEnter(object sender, MouseEventArgs e)
        {
            Exiterr.Visibility = Visibility.Visible;
        }

        private void exit_MouseLeave(object sender, MouseEventArgs e)
        {
            Exiterr.Visibility=Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window Window1 = new Window1();
            this.Close();
            Window1.Show();
            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window window2 = new Login();
            this.Close();
            window2.Show();

        }
    }
}