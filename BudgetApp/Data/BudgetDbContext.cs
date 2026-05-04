namespace BudgetApp;

using BudgetApp.Classes;
using Microsoft.EntityFrameworkCore;

public class BudgetDbContext : DbContext
{
    public DbSet<Budget> Budgets { get; set; }
    public DbSet<Expense> Expenses { get; set; }
    public DbSet<Income> Incomes { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=BudgetDB;Trusted_Connection=True;");
        base.OnConfiguring(optionsBuilder);
    }
}