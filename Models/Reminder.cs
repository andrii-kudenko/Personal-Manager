using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace PersonalManager.Models
{
    public class Reminder
    {
        public string Title {get; set;}
        public string TitleString {
            get
            {
                if (Title.Length > 27)
                    return new string(Title.Take(27).ToArray()) + "...";
                return Title;
            }
        } 

        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
