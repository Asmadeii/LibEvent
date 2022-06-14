using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibEvent
{
    public class CalendarNote
    {
        public int year;
        public int month;
        public int day;
        public string note;
    }
    public class CalendarNotes
    {
        private static List<CalendarNote> _notes = new List<CalendarNote>();
        public static void AddNote(CalendarNote note)
        {
            _notes.Add(note);
        }
    }
}
