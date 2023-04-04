using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalManager.Models
{

    public enum ExpensesCategory
    {
        Housing, Transportation, Food, HealthFitness, PersonalCare, Education, DebtPayments, Insuarance, GiftsDonations, Other
    }
    public class Expense
    {
        public float Amount { get; set; }
        public ExpensesCategory ExpenseCategory { get; set; }
        public string Details { get; set; }
    }
}
