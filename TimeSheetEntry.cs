using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetManagement
{
    public class TimeSheetEntry
    {
        public DateTime Date { get; }
        public double HoursWorked { get; }
        public string Description { get; }

        public TimeSheetEntry(DateTime date, double hoursWorked, string description)
        {
            Date = date;
            HoursWorked = hoursWorked;
            Description = description;
        }
    }
}
