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

namespace InvoiceManagement
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        public void OnPasswordChanged (object sender, EventArgs e)
        {
            LoginButton.IsEnabled =
        }
        private void OnLoggedIn_Click(object sender, RoutedEventArgs e)
        {
            string passwordEntered = PasswordBox.Password;
            string? envpass =Environment.GetEnvironmentVariable("InvoiceManagement");

            if (envpass != null)
            {
                if(passwordEntered == envpass)
                {
                    MessageBox.Show("Successfully Logged In");
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
            else
            {
                MessageBox.Show("Environment Not Found");
            }
        
        }
    }
}
