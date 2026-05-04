namespace BudgetApp.Classes;

public class Income
{
    public int Id { get; set; }
    public int BudgetId { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Amount { get; set; }

    public Budget Budget { get; set; } = null!;
}
