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
    /// Interaction logic for MyBudgets.xaml
    /// </summary>
    public partial class MyBudgets : Page
    {
        User user;
        Budget currentBudget;
        FileManager fileManager = new FileManager();
        HomePage homePage;
        SettingsPage settingsPage;
        AddSavingsPage addSavingsPage;
        EditBudgetPage editBudgetPage;
        
        BudgetWindow budgetWindow;


        public MyBudgets(User user, Budget budget, HomePage homePage, SettingsPage settingsPage,
                         AddSavingsPage addSavingsPage, EditBudgetPage editBudgetPage, BudgetWindow budgetWindow)
        {
            InitializeComponent();

            currentBudget = budget;
            this.user = user;
            this.homePage = homePage;
            this.settingsPage = settingsPage;
            this.addSavingsPage = addSavingsPage;
            this.budgetWindow = budgetWindow;
            this.editBudgetPage = editBudgetPage;

            ListBudgets();
        }


        private void selectBudgetCutton_Click(object sender, RoutedEventArgs e)
        {
            UpdateBudget();
        }


        private void removeBudgetButton_Click(object sender, RoutedEventArgs e)
        {
            DeleteBudget();
        }


        private void budgetsListbox_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            ListBudgets();
        }


        private void ListBudgets()
        {
            budgetsListbox.Items.Clear();

            for (int i = user.budgets.Count - 1; i >= 0; i--)
            {
                budgetsListbox.Items.Add(user.budgets[i]);
            }
        }


        private void UpdateBudget()
        {
            if (budgetsListbox.SelectedItem != null)
            {
                homePage.UpdateDataContext(GetBudget());
                //homePage.DataContext = GetBudget();
                //homePage.UpdateCurrentBudget(GetBudget());
                homePage.ListIncomes();
                homePage.ListExpenses();

                settingsPage.UpdateCurrentBudget(GetBudget());
                addSavingsPage.UpdateCurrentBudget(GetBudget());
                editBudgetPage.UpdateCurrentBudget(GetBudget());

                editBudgetPage.ListIncomes();
                editBudgetPage.ListExpenses();

                budgetWindow.currentBudget = GetBudget();
                budgetWindow.currentBudgetText.Text = GetBudget().Name;
                budgetWindow.ShowHomeFrame();
            }
        }


        private void DeleteBudget()
        {
            if (budgetsListbox.SelectedItem != null)
            {
                if ((Budget)budgetsListbox.SelectedItem == currentBudget || budgetsListbox.SelectedIndex != 0)
                {
                    currentBudget = (Budget)budgetsListbox.Items[0];

                    homePage.DataContext = currentBudget;
                    homePage.UpdateCurrentBudget(currentBudget);
                    homePage.ListIncomes();
                    homePage.ListExpenses();

                    settingsPage.UpdateCurrentBudget(currentBudget);
                    addSavingsPage.UpdateCurrentBudget(currentBudget);

                    budgetWindow.currentBudget = currentBudget;
                    budgetWindow.currentBudgetText.Text = currentBudget.Name;
                }

                if ((Budget)budgetsListbox.SelectedItem == currentBudget || budgetsListbox.SelectedIndex == 0)
                {
                    try
                    {
                        currentBudget = (Budget)budgetsListbox.Items[1];

                        homePage.DataContext = currentBudget;
                        homePage.UpdateCurrentBudget(currentBudget);
                        homePage.ListIncomes();
                        homePage.ListExpenses();

                        settingsPage.UpdateCurrentBudget(currentBudget);
                        addSavingsPage.UpdateCurrentBudget(currentBudget);

                        budgetWindow.currentBudget = currentBudget;
                        budgetWindow.currentBudgetText.Text = currentBudget.Name;
                    }
                    catch (Exception ex)
                    {
                        homePage.DataContext = null;
                        homePage.UpdateCurrentBudget(currentBudget);
                        homePage.incomeListbox.Items.Clear();
                        homePage.expensesListbox.Items.Clear();

                    }
                }

                user.budgets.Reverse();
                user.budgets.RemoveAt(budgetsListbox.SelectedIndex);
                user.budgets.Reverse();
                fileManager.UpdateUser(user);
                budgetsListbox.Items.Remove(budgetsListbox.SelectedItem);
            }
        }


        public Budget GetBudget()
        {
            return (Budget)budgetsListbox.SelectedItem;
        }
    }
}
