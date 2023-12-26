using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Classes
{
    public class Expense
    {
        public string Name { get; set; }
        public int Amount { get; set; }

        public Expense(string name, int amount)
        {
            Name = name;
            Amount = amount;
        }
    }
}
