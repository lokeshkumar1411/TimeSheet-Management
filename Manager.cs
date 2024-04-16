using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetManagement
{
    public class Manager : Register
    {
        public void ViewAllTimeSheets(Dictionary<int, List<TimeSheetEntry>> userTimeSheets)
        {
            if (userTimeSheets.Count == 0)
            {
                Console.WriteLine("There is no entries yet.");
            }
            else
            {
                Console.WriteLine("All Timesheet Entries:");
                Console.WriteLine();

                foreach (KeyValuePair<int, List<TimeSheetEntry>> userEntry in userTimeSheets)
                {
                    foreach (var entry in userEntry.Value)
                    {
                        Console.WriteLine($"User : {userEntry.Key} ,Date: {entry.Date.ToShortDateString()}, Hours: {entry.HoursWorked}, Description: {entry.Description}");
                        Console.WriteLine();
                    }
                }
            }

        }
    }
}
