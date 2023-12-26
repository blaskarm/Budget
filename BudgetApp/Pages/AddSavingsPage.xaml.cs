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
    /// Interaction logic for AddSavingsPage.xaml
    /// </summary>
    public partial class AddSavingsPage : Page
    {
        User user;
        Budget currentBudget;

        BudgetWindow budgetWindow;
        HomePage homePage;

        FileManager fileManager = new FileManager();


        public AddSavingsPage(User user, Budget budget, BudgetWindow budgetWindow, HomePage homePage)
        {
            InitializeComponent();
            this.user = user;
            currentBudget = budget;
            this.budgetWindow = budgetWindow;
            this.homePage = homePage;
        }


        private void addSavingButton_Click(object sender, RoutedEventArgs e)
        {
            AddSavings();
        }


        private void subtractSavingButton_Click(object sender, RoutedEventArgs e)
        {
            SubtractSavings();
        }


        private void removeSavingAmountTextbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }


        private void addSavingAmountTextbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }


        private void AddSavings()
        {
            if (addSavingAmountTextbox.Text != "")
            {
                currentBudget.AddSavings(Convert.ToInt32(addSavingAmountTextbox.Text));
                currentBudget.CalculateNetTotal();

                fileManager.UpdateUser(user);

                homePage.UpdateDataContext(currentBudget);

                budgetWindow.ShowHomeFrame();

                addSavingAmountTextbox.Text = "";
            }
        }


        private void SubtractSavings()
        {
            if (removeSavingAmountTextbox.Text != "")
            {
                currentBudget.SubtractSavings(Convert.ToInt32(removeSavingAmountTextbox.Text));
                currentBudget.CalculateNetTotal();

                fileManager.UpdateUser(user);

                homePage.UpdateDataContext(currentBudget);

                budgetWindow.ShowHomeFrame();

                removeSavingAmountTextbox.Text = "";
            }
        }


        public void UpdateCurrentBudget(Budget budget)
        {
            currentBudget = budget;
        }
    }
}
