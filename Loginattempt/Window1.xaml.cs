using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
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

namespace Loginattempt
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        
        public Window1()
        {
            DataContext = this;
            InitializeComponent();
        }
        private string BoundUser;

        public string boundUser
        {
            get { return BoundUser; }
            set { BoundUser = value; }
        }

        private string BoundPass;

        public string  boundPass
        {
            get { return BoundPass; }
            set { BoundPass = value; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string filePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Logins.txt");
            using (StreamWriter sw = new StreamWriter(filePath, true)) 
            {
                sw.WriteLine($"{BoundUser}-{BoundPass}");
                MessageBox.Show("Account Created");
                Window MainW = new MainWindow();
                MainW.Show();
                this.Close();
                
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window window = new Login();
            this.Close();
            window.Show();
        }
    }
}
