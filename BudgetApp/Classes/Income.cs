using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Classes
{
    public class Income
    {
        public string Name { get; set; }
        public int Amount { get; set; }

        public Income(string name, int amount)
        {
            Name = name;
            Amount = amount;
        }
    }
}
