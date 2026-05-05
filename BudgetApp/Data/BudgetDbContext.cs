namespace BudgetApp.Data;

using BudgetApp.Classes;
using Microsoft.EntityFrameworkCore;

public class BudgetDbContext : DbContext
{
    public DbSet<Budget> Budgets { get; set; }
    public DbSet<Expense> Expenses { get; set; }
    public DbSet<Income> Incomes { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasKey(u => u.Id);
        modelBuilder.Entity<User>()
            .Property(u => u.Name)
            .IsRequired()
            .HasMaxLength(100);

        modelBuilder.Entity<User>()
            .Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(360);

        modelBuilder.Entity<User>()
            .HasMany(u => u.Budgets)
            .WithOne(b => b.User)
            .HasForeignKey(b => b.UserId)
            .OnDelete(DeleteBehavior.Cascade);


        modelBuilder.Entity<Budget>()
            .HasKey(b => b.Id);

        modelBuilder.Entity<Budget>()
            .Property(b => b.Name)
            .IsRequired()
            .HasMaxLength(100);

        modelBuilder.Entity<Budget>()
            .HasMany(b => b.Incomes)
            .WithOne(i => i.Budget)
            .HasForeignKey(i => i.BudgetId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Budget>()
            .HasMany(b => b.Expenses)
            .WithOne(e => e.Budget)
            .HasForeignKey(i => i.BudgetId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}