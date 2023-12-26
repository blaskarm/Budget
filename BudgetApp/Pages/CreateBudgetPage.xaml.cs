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
    /// Interaction logic for CreateBudgetPage.xaml
    /// </summary>
    public partial class CreateBudgetPage : Page
    {
        User user;
        List<Expense> expenses = new List<Expense>();
        List<Income> incomes = new List<Income>();
        FileManager fileManager = new FileManager();

        BudgetWindow budgetWindow;
        HomePage homePage;
        SettingsPage settingsPage;
        AddSavingsPage addSavingsPage;
        EditBudgetPage editBudgetPage;


        public CreateBudgetPage(User user, BudgetWindow budgetWindow, HomePage homePage, SettingsPage settingsPage,
                                AddSavingsPage addSavingsPage, EditBudgetPage editBudgetPage)
        {
            InitializeComponent();
            this.user = user;
            this.budgetWindow = budgetWindow;
            this.homePage = homePage;
            this.settingsPage = settingsPage;
            this.addSavingsPage = addSavingsPage;
            this.editBudgetPage = editBudgetPage;
        }


        private void addExpenseButton_Click(object sender, RoutedEventArgs e)
        {
            AddExpenseToList();
        }

        private void removeExpenseButton_Click(object sender, RoutedEventArgs e)
        {
            RemoveExpenseFromList();
        }


        private void removeIncomeButton_Click(object sender, RoutedEventArgs e)
        {
            RemoveIncomeFromList();
        }

        private void addIncomeButton_Click(object sender, RoutedEventArgs e)
        {
            AddIncomeToList();
        }


        private void saveBudgetButton_Click(object sender, RoutedEventArgs e)
        {
            SaveBudget();
        }


        private void AddIncomeToList()
        {
            if (typeOfIncomeTextbox.Text != "" && incomeAmountTextbox.Text != "")
            {
                incomes.Add(new Income(typeOfIncomeTextbox.Text, Convert.ToInt32(incomeAmountTextbox.Text)));
                incomeListBox.Items.Add(typeOfIncomeTextbox.Text + "\t" + incomeAmountTextbox.Text + ":-");

                ResetTextBoxes();
            }
        }

        private void RemoveIncomeFromList()
        {
            if (incomeListBox.SelectedItem != null)
            {
                incomes.RemoveAt(incomeListBox.SelectedIndex);
                incomeListBox.Items.Remove(incomeListBox.SelectedItem);
            }
        }


        private void AddExpenseToList()
        {
            if (nameOfExpenseTextbox.Text != "" && expenseAmountTextbox.Text != "")
            {
                expenses.Add(new Expense(nameOfExpenseTextbox.Text, Convert.ToInt32(expenseAmountTextbox.Text)));
                expensesListBox.Items.Add(nameOfExpenseTextbox.Text + "\t" + expenseAmountTextbox.Text + ":-");

                ResetTextBoxes();
            }
        }

        private void RemoveExpenseFromList()
        {
            if (expensesListBox.SelectedItem != null)
            {
                expenses.RemoveAt(expensesListBox.SelectedIndex);
                expensesListBox.Items.Remove(expensesListBox.SelectedItem);
            }
        }


        private void SaveBudget()
        {
            Budget budget = new Budget();

            budget.AddIncomes(incomes);
            budget.AddExpenses(expenses);
            budget.CalculateNetTotal();

            budgetWindow.currentBudget = budget;
            budgetWindow.currentBudgetText.Text = budget.Name;

            homePage.UpdateDataContext(budget);
            // homePage.DataContext = budget;
            homePage.ListIncomes();
            homePage.ListExpenses();

            settingsPage.UpdateCurrentBudget(budget);
            addSavingsPage.UpdateCurrentBudget(budget);
            editBudgetPage.UpdateCurrentBudget(budget);

            user.budgets.Add(budget);
            fileManager.UpdateUser(user);

            incomeListBox.Items.Clear();
            expensesListBox.Items.Clear();

            incomes.Clear();
            expenses.Clear();

            budgetWindow.ShowHomeFrame();
        }


        private void ResetTextBoxes()
        {
            typeOfIncomeTextbox.Text = "";
            incomeAmountTextbox.Text = "";
            nameOfExpenseTextbox.Text = "";
            expenseAmountTextbox.Text = "";
        }


        private void expenseAmountTextbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void incomeAmountTextbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }
    }
}
