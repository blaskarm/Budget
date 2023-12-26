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
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        User user;
        Budget currentBudget;
        BudgetWindow budgetWindow;

        public HomePage(User user, Budget currentBudget, BudgetWindow budgetWindow)
        {
            InitializeComponent();
            this.user = user;
            this.currentBudget = currentBudget;
            this.budgetWindow = budgetWindow;
            this.DataContext = currentBudget;
            currentBudgetText.Text = currentBudget.Name;

            ListIncomes();
            ListExpenses();
        }


        private void editBudgetButton_Click(object sender, RoutedEventArgs e)
        {
            if (user.budgets.Any())
            {
                budgetWindow.ShowEditBudgetFrame();
            }
        }


        public void UpdateCurrentBudget(Budget budget)
        {
            currentBudget = budget;
            currentBudgetText.Text = currentBudget.Name;
        }


        public void ListIncomes()
        {
            incomeListbox.Items.Clear();

            foreach (Income income in currentBudget.incomes)
            {
                incomeListbox.Items.Add(income.Name + "\t" + income.Amount + ":-");
            }
        }


        public void ListExpenses()
        {
            expensesListbox.Items.Clear();

            foreach (Expense expense in currentBudget.expenses)
            {
                expensesListbox.Items.Add(expense.Name + "\t" + expense.Amount + ":-");
            }
        }


        public void UpdateDataContext(Budget budget)
        {
            currentBudget = budget;
            this.DataContext = null;
            this.DataContext = currentBudget;
        }


        public Budget GetBudget()
        {
            return currentBudget;
        }
    }
}
