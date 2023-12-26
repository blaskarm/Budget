using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Classes
{
    public class Budget
    {
        public string Name { get; set; }
        public int Savings { get; set; }
        public int NetTotal { get; set; }

        public List<Income> incomes = new List<Income>();
        public List<Expense> expenses = new List<Expense>();

        public Budget()
        {
            Name = DateTime.Today.ToShortDateString();
        }

        public void AddIncomes(List<Income> _incomes)
        {
            foreach (Income income in _incomes)
            {
                incomes.Add(income);
            }
        }

        public void AddExpenses(List<Expense> _expenses)
        {
            foreach (Expense expense in _expenses)
            {
                expenses.Add(expense);
            }
        }

        public void AddSavings(int amount)
        {
            Savings += amount;
        }

        public void SubtractSavings(int amount)
        {
            Savings -= amount;
        }

        public void CalculateNetTotal()
        {
            NetTotal = 0;
            foreach (Income i in incomes)
            {
                NetTotal += i.Amount;
            }

            foreach (Expense e in expenses)
            {
                NetTotal -= e.Amount;
            }
            NetTotal -= Savings;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
