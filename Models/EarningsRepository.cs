using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalManager.Models
{
    public static class EarningsRepository
    {
        private static List<Earning> _earnings;
        static EarningsRepository()
        {
            _earnings= new List<Earning>();
            PopulateList();
        }
        private static void PopulateList()
        {
            _earnings.Add(new Earning {Amount=124.12, EarningCategory=EarningsCategory.Work, Details="1st part of salary in April"});
            _earnings.Add(new Earning { Amount = 500, EarningCategory = EarningsCategory.Gifts, Details = "Gift from my friend" });
            _earnings.Add(new Earning { Amount = 1250, EarningCategory = EarningsCategory.Investments, Details = "Apple stonks" });
            _earnings.Add(new Earning { Amount = 1250, EarningCategory = EarningsCategory.Investments, Details = "Apple stonks" });
            _earnings.Add(new Earning { Amount = 1250, EarningCategory = EarningsCategory.Investments, Details = "Apple stonks" });
            _earnings.Add(new Earning { Amount = 1250, EarningCategory = EarningsCategory.Investments, Details = "Apple stonks" });
            _earnings.Add(new Earning { Amount = 1250, EarningCategory = EarningsCategory.Investments, Details = "Apple stonks" });
            _earnings.Add(new Earning { Amount = 1250, EarningCategory = EarningsCategory.Investments, Details = "Apple stonks" });
            _earnings.Add(new Earning { Amount = 1250, EarningCategory = EarningsCategory.Investments, Details = "Apple stonks" });

        }

        public static List<Earning> GetEarnings()
        {
            return _earnings;
        } 

    }
}
