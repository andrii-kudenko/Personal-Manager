using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalManager.Models
{
    public static class NotesRepository
    {
        private static List<Note> _notes;
        static NotesRepository()
        {
            _notes = new List<Note>();
            PopulateList();
        }
        private static void PopulateList()
        {
            _notes.Add(new Note { Title = "Shopping list", Text = "1. Carrots\n2. Meat\n3. Pasta\n3. Pasta\n3. Pasta\n3. Pasta" });
            _notes.Add(new Note { Title = "Project ideas", Text = "1. Fitness app 2. Personal Manager 3. Mobile Game" });
        }

        public static List<Note> GetNotes()
        {
            return _notes;
        }
    }
}
