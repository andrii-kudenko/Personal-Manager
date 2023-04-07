using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalManager.Models
{
    public static class RemindersRepository
    {
        private static List<Reminder> _reminders;
        static RemindersRepository()
        {
            _reminders = new List<Reminder>();
            PopulateList();
        }
        private static void PopulateList()
        {
            _reminders.Add(new Reminder {Title = "Make homeworkkkkkkkkkkkkkkkkkkkkk", //30 symbols => 27 allowed
                Text = "1. Make a c# assignment\n2. Make math Assignment", Date = new DateTime(2023, 4, 15)});
            _reminders.Add(new Reminder {
                Title = "Make ho", //30 symbols => 27 allowed
                Text = "1. Make a c# assignment\n2. Make math Assignment",
                Date = new DateTime(2023, 4, 15)
            });
        }

        public static List<Reminder> GetReminders()
        {
            return _reminders;
        }
    }
}
