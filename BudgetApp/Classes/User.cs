using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Classes
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Date {  get; set; }

        public List<Budget> budgets = new List<Budget>();

        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
            Date = DateTime.Today.ToShortDateString();
        }
    }
}
