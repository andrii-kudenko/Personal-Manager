using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalManager.Models
{
    public enum EarningsCategory
    {
        Work, GiftsDonations, Investments, RentalIncome, PersonalLoans, Other
    }
    public class Earning
    {
        public float Amount { get; set; }
        public EarningsCategory EarningCategory { get; set; }
        public string Details { get; set; }
    }
}
