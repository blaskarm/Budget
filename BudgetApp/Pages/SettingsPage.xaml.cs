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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BudgetApp.Pages
{
    /// <summary>
    /// Interaction logic for SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        Budget currentBudget;
        User user;
        HomePage homePage;
        BudgetWindow budgetWindow;
        FileManager fileManager = new FileManager();

        public SettingsPage(User user, Budget budget, HomePage homePage, BudgetWindow budgetWindow)
        {
            InitializeComponent();
            currentBudget = budget;
            this.user = user;
            this.homePage = homePage;
            this.budgetWindow = budgetWindow;
        }

        private void changeBudgetNameButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeBudgetName();
        }

        private void changePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            ChangePassword();
        }

        private void ChangeBudgetName()
        {
            if (changeBudgetNameTextBox.Text != "")
            {
                currentBudget.Name = changeBudgetNameTextBox.Text;
                ResetTextBoxes();
                fileManager.UpdateUser(user);
                homePage.UpdateCurrentBudget(currentBudget);
                budgetWindow.currentBudget = currentBudget;
                budgetWindow.currentBudgetText.Text = currentBudget.Name;
            }
        }


        private void ChangePassword()
        {
            if (currentPasswordTextBox.Password == user.Password &&
                newPasswordTextBox.Password == confirmPasswordTextBox.Password)
            {
                user.Password = newPasswordTextBox.Password;
                fileManager.UpdateUser(user);
                ResetTextBoxes();

            }
            else
            {
                MessageBox.Show("Something went wrong!");
            }
        }


        public void UpdateCurrentBudget(Budget budget)
        {
            currentBudget = budget;
        }


        private void ResetTextBoxes()
        {
            changeBudgetNameTextBox.Text = "";
            currentPasswordTextBox.Password = "";
            newPasswordTextBox.Password = "";
            confirmPasswordTextBox.Password = "";
        }
    }
}
