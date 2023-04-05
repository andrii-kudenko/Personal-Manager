using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalManager.Models
{
    public static class ExpensesRepository
    {
        private static List<Expense> _expenses;
        static ExpensesRepository()
        {
            _expenses = new List<Expense>();
            PopulateList();
        }
        private static void PopulateList()
        {
            _expenses.Add(new Expense { Amount = 2150, ExpenseCategory = ExpensesCategory.Housing, Details = "Payment for April"});
            _expenses.Add(new Expense { Amount = 126.56, ExpenseCategory = ExpensesCategory.Food, Details = "Walmart" });
            _expenses.Add(new Expense { Amount = 1500, ExpenseCategory = ExpensesCategory.GiftsDonations, Details = "From Mom" });
            _expenses.Add(new Expense { Amount = 3.5, ExpenseCategory = ExpensesCategory.Transportation, Details = "Bus" });

        }

        public static List<Expense> GetEarnings()
        {
            return _expenses;
        }

    }
}
