using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalManager.Models
{
    public class ExpensePercentage
    {
        public string Category { get; set; }
        public double Percentage { get; set; }
        public string Description { get
            {
                return $"{Category}" + ": " + $"{Percentage}" + "%";
            } }
    }
}
