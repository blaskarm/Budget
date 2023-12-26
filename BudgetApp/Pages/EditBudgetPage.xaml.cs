using BudgetApp.Classes;
using Newtonsoft.Json.Bson;
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
    /// Interaction logic for EditBudgetPage.xaml
    /// </summary>
    public partial class EditBudgetPage : Page
    {
        User user;
        Budget currentBudget;
        List<Expense> expenses = new List<Expense>();
        List<Income> incomes = new List<Income>();
        FileManager fileManager = new FileManager();

        BudgetWindow budgetWindow;
        HomePage homePage;


        public EditBudgetPage(User user, Budget budget, BudgetWindow budgetWindow, HomePage homePage)
        {
            InitializeComponent();
            this.user = user;
            currentBudget = budget;
            this.budgetWindow = budgetWindow;
            this.homePage = homePage;

            AddIncomesToClassList();
            AddExpensesToClassList();
            ListIncomes();
            ListExpenses();
        }


        private void addIncomeButton_Click(object sender, RoutedEventArgs e)
        {
            AddIncomeToList();
        }

        private void addExpenseButton_Click(object sender, RoutedEventArgs e)
        {
            AddExpenseToList();
        }

        private void removeIncomeButton_Click(object sender, RoutedEventArgs e)
        {
            RemoveIncomeFromList();
        }

        private void removeExpenseButton_Click(object sender, RoutedEventArgs e)
        {
            RemoveExpenseFromList();
        }

        private void saveBudgetButton_Click(object sender, RoutedEventArgs e)
        {
            SaveBudget();
        }


        private void AddIncomeToList()
        {
            if (typeOfIncomeTextBox.Text != "" && incomeAmountTextbox.Text != "")
            {
                incomes.Add(new Income(typeOfIncomeTextBox.Text, Convert.ToInt32(incomeAmountTextbox.Text)));
                incomeListBox.Items.Add(typeOfIncomeTextBox.Text + "\t" + incomeAmountTextbox.Text + ":-");

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
            if (nameOfExpenseTextBox.Text != "" && expenseAmountTextbox.Text != "")
            {
                expenses.Add(new Expense(nameOfExpenseTextBox.Text, Convert.ToInt32(expenseAmountTextbox.Text)));
                expensesListBox.Items.Add(nameOfExpenseTextBox.Text + "\t" + expenseAmountTextbox.Text + ":-");

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
            currentBudget.incomes.Clear();
            currentBudget.expenses.Clear();
            currentBudget.AddIncomes(incomes);
            currentBudget.AddExpenses(expenses);
            currentBudget.CalculateNetTotal();

            homePage.UpdateDataContext(currentBudget);
            homePage.ListIncomes();
            homePage.ListExpenses();

            fileManager.UpdateUser(user);

            incomeListBox.Items.Clear();
            expensesListBox.Items.Clear();

            incomes.Clear();
            expenses.Clear();

            budgetWindow.ShowHomeFrame();
        }

        
        public void ListIncomes()
        {
            incomeListBox.Items.Clear();

            foreach (Income income in currentBudget.incomes)
            {
                incomeListBox.Items.Add(income.Name + "\t" + income.Amount + ":-");
            }
        }


        public void ListExpenses()
        {
            expensesListBox.Items.Clear();

            foreach (Expense expense in currentBudget.expenses)
            {
                expensesListBox.Items.Add(expense.Name + "\t" + expense.Amount + ":-");
            }
        }

        private void AddIncomesToClassList()
        {
            incomes.Clear();
            foreach (Income income in currentBudget.incomes)
            {
                incomes.Add(income);
            }
        }


        private void AddExpensesToClassList()
        {
            expenses.Clear();
            foreach (Expense expense in currentBudget.expenses)
            {
                expenses.Add(expense);
            }
        }


        private void ResetTextBoxes()
        {
            typeOfIncomeTextBox.Text = "";
            incomeAmountTextbox.Text = "";
            nameOfExpenseTextBox.Text = "";
            expenseAmountTextbox.Text = "";
        }


        public void UpdateCurrentBudget(Budget budget)
        {
            currentBudget = budget;
        }


        private void incomeAmountTextbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }


        private void expenseAmountTextbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void incomeListBox_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            AddIncomesToClassList();
            ListIncomes();
        }

        private void expensesListBox_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            AddExpensesToClassList();
            ListExpenses();
        }
    }
}
