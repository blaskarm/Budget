using BudgetApp.Classes;
using Newtonsoft.Json.Bson;
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

namespace BudgetApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    

    // Login Window
    public partial class MainWindow : Window
    {
        List<User> users = new List<User>();
        User? user;
        FileManager fileManager = new FileManager();

        public MainWindow()
        {
            InitializeComponent();
            users = fileManager.ReadUsers(users);
            LoginUsernameTextBox.Focus();
        }

        private void CreateAccountButton_Click(object sender, RoutedEventArgs e)
        {
            SignUpWindow signUpWindow = new SignUpWindow(users);
            signUpWindow.ShowDialog();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (CheckUser(out user) && user != null)
            {
                BudgetWindow budgetWindow = new BudgetWindow(user);
                budgetWindow.Show();
                this.Close();
            }
        }

        private bool CheckUser(out User loggedInUser)
        {
            loggedInUser = null;

            foreach (User user in users)
            {
                if (user.Email == LoginUsernameTextBox.Text.ToLower() && user.Password == LoginPasswordBox.Password)
                {
                    loggedInUser = user;
                    return true;
                }
            }
            return false;
        }
    }
}