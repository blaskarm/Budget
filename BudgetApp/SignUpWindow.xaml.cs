using BudgetApp.Classes;
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

namespace BudgetApp
{
    /// <summary>
    /// Interaction logic for SignUpWindow.xaml
    /// </summary>
    public partial class SignUpWindow : Window
    {
        FileManager fileManager = new FileManager();
        List<User> users;

        public SignUpWindow(List<User> users)
        {
            InitializeComponent();
            SignUpNameTextBox.Focus();
            this.users = users;
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            if (SignUpPasswordBox.Password != "" && SignUpConfirmPasswordBox.Password != "" &&
                SignUpPasswordBox.Password == SignUpConfirmPasswordBox.Password)
            {
                if (UserExists())
                {
                    MessageBox.Show("Email already exists");
                    ResetTextBoxes();
                }
                else
                {
                    users.Add(new User(SignUpNameTextBox.Text, SignUpEmailTextBox.Text.ToLower(), SignUpPasswordBox.Password));
                    fileManager.CreateNewUser(users);
                    this.Close();
                }
            }
            else
            {
                PasswordDontMatchText.Visibility = Visibility.Visible;
                ResetTextBoxes();
            }
        }

        private void SignUpNameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordDontMatchText.Visibility = Visibility.Hidden;
        }

        private bool UserExists()
        {
            foreach (User user in users)
            {
                if (user.Email == SignUpEmailTextBox.Text)
                {
                    return true;
                }
            }
            return false;
        }

        private void ResetTextBoxes()
        {
            SignUpNameTextBox.Text = string.Empty;
            SignUpEmailTextBox.Text = string.Empty;
            SignUpPasswordBox.Password = string.Empty;
            SignUpConfirmPasswordBox.Password = string.Empty;
        }
    }
}
