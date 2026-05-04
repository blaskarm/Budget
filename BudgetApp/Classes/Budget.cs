namespace BudgetApp.Classes;

public class Budget
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Name { get; set; }
    public int Savings { get; set; }
    public int NetTotal { get; set; }

    public User User { get; set; }
    public List<Income> Incomes { get; set; } = [];
    public List<Expense> Expenses { get; set; } = [];

    public Budget()
    {
        Name = DateTime.Today.ToShortDateString();
    }

    public void AddIncomes(List<Income> _incomes)
    {
        foreach (Income income in _incomes)
        {
            Incomes.Add(income);
        }
    }

    public void AddExpenses(List<Expense> _expenses)
    {
        foreach (Expense expense in _expenses)
        {
            Expenses.Add(expense);
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
        foreach (Income i in Incomes)
        {
            NetTotal += i.Amount;
        }

        foreach (Expense e in Expenses)
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
