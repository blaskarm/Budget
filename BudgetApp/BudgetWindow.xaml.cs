using BudgetApp.Classes;
using BudgetApp.Pages;
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
    /// Interaction logic for BudgetWindow.xaml
    /// </summary>
    public partial class BudgetWindow : Window
    {
        User user;
        public Budget currentBudget;
        FileManager fileManager = new FileManager();
        HomePage homePage;
        CreateBudgetPage createBudgetPage;
        AddSavingsPage addSavingsPage;
        MyBudgets myBudgetsPage;
        SettingsPage settingsPage;
        EditBudgetPage editBudgetPage;

        public BudgetWindow(User user)
        {
            InitializeComponent();
            this.user = user;
            this.DataContext = user;

            if (!user.budgets.Any())
            {
                user.budgets.Add(new Budget());
                fileManager.UpdateUser(user);
            }

            currentBudget = user.budgets[user.budgets.Count - 1];

            homePage = new HomePage(user, currentBudget, this);
            homeFrame.Navigate(homePage);


            addSavingsPage = new AddSavingsPage(user, currentBudget, this, homePage);
            addSavingsFrame.Navigate(addSavingsPage);
            addSavingsFrame.Visibility = Visibility.Hidden;


            settingsPage = new SettingsPage(user, currentBudget, homePage, this);
            settingsFrame.Navigate(settingsPage);
            settingsFrame.Visibility = Visibility.Hidden;


            createBudgetPage = new CreateBudgetPage(user, this, homePage, settingsPage, addSavingsPage);
            createBudgetFrame.Navigate(createBudgetPage);
            createBudgetFrame.Visibility = Visibility.Hidden;


            editBudgetPage = new EditBudgetPage(user, currentBudget, this, homePage);
            editBudgetFrame.Navigate(editBudgetPage);
            editBudgetFrame.Visibility = Visibility.Hidden;


            myBudgetsPage = new MyBudgets(user, currentBudget, homePage, settingsPage, addSavingsPage, editBudgetPage, this);
            myBudgetsFrame.Navigate(myBudgetsPage);
            myBudgetsFrame.Visibility = Visibility.Hidden;

            currentBudgetText.Text = currentBudget.Name;
        }


        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            mainTextBlock.Text = homeButton.Content.ToString();
            homeFrame.Visibility = Visibility.Visible;

            createBudgetFrame.Visibility = Visibility.Hidden;
            addSavingsFrame.Visibility = Visibility.Hidden;
            myBudgetsFrame.Visibility = Visibility.Hidden;
            settingsFrame.Visibility = Visibility.Hidden;
            editBudgetFrame.Visibility = Visibility.Hidden;
        }


        private void createBudgetButton_Click(object sender, RoutedEventArgs e)
        {
            mainTextBlock.Text = createBudgetButton.Content.ToString();
            createBudgetFrame.Visibility = Visibility.Visible;

            homeFrame.Visibility = Visibility.Hidden;
            addSavingsFrame.Visibility = Visibility.Hidden;
            myBudgetsFrame.Visibility = Visibility.Hidden;
            settingsFrame.Visibility = Visibility.Hidden;
            editBudgetFrame.Visibility = Visibility.Hidden;
        }


        private void addSavingsButton_Click(object sender, RoutedEventArgs e)
        {
            mainTextBlock.Text = addSavingsButton.Content.ToString();
            addSavingsFrame.Visibility = Visibility.Visible;

            homeFrame.Visibility = Visibility.Hidden;
            createBudgetFrame.Visibility = Visibility.Hidden;
            myBudgetsFrame.Visibility = Visibility.Hidden;
            settingsFrame.Visibility = Visibility.Hidden;
            editBudgetFrame.Visibility = Visibility.Hidden;
        }


        private void myBudgetsButton_Click(object sender, RoutedEventArgs e)
        {
            mainTextBlock.Text = myBudgetsButton.Content.ToString();
            myBudgetsFrame.Visibility = Visibility.Visible;

            homeFrame.Visibility = Visibility.Hidden;
            createBudgetFrame.Visibility = Visibility.Hidden;
            addSavingsFrame.Visibility = Visibility.Hidden;
            settingsFrame.Visibility = Visibility.Hidden;
            editBudgetFrame.Visibility = Visibility.Hidden;
        }


        private void settingsButton_Click(object sender, RoutedEventArgs e)
        {
            mainTextBlock.Text = settingsButton.Content.ToString();
            settingsFrame.Visibility = Visibility.Visible;

            homeFrame.Visibility = Visibility.Hidden;
            createBudgetFrame.Visibility = Visibility.Hidden;
            addSavingsFrame.Visibility = Visibility.Hidden;
            myBudgetsFrame.Visibility = Visibility.Hidden;
            editBudgetFrame.Visibility = Visibility.Hidden;
        }


        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }


        public void ShowEditBudgetFrame()
        {
            mainTextBlock.Text = "Edit Budget";
            editBudgetFrame.Visibility = Visibility.Visible;

            homeFrame.Visibility = Visibility.Hidden;
            createBudgetFrame.Visibility = Visibility.Hidden;
            addSavingsFrame.Visibility = Visibility.Hidden;
            myBudgetsFrame.Visibility = Visibility.Hidden;
            settingsFrame.Visibility = Visibility.Hidden;
        }

        public void ShowHomeFrame()
        {
            mainTextBlock.Text = homeButton.Content.ToString();
            homeFrame.Visibility = Visibility.Visible;

            createBudgetFrame.Visibility = Visibility.Hidden;
            addSavingsFrame.Visibility = Visibility.Hidden;
            myBudgetsFrame.Visibility = Visibility.Hidden;
            settingsFrame.Visibility = Visibility.Hidden;
            editBudgetFrame.Visibility = Visibility.Hidden;
        }
    }
}
