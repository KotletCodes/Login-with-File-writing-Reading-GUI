using System;
using System.Collections.Generic;
using System.IO;
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

namespace Loginattempt
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
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

        public string boundPass
        {
            get { return BoundPass; }
            set { BoundPass = value; }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool found = false;
            string filePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Logins.txt");
            
            string total = $"{BoundUser}-{BoundPass}";
            string[] file = File.ReadAllLines(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Logins.txt"));
            
            foreach (string line in file)
            {
                if (line == total)
                {
                    found = true;
                }
            }
            if (found == true)
            {
                MessageBox.Show("Login success");
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
        }
    }
}
