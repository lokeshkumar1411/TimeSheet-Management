using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetManagement;

namespace TimeSheetManagement
{
    internal class ViweUserTimeSheet
    {
        public void ViewUserTimeSheet(Dictionary<int, List<TimeSheetEntry>> userTimeSheets)
        {
            Console.Write("Enter User ID: ");
            int viewUserId = int.Parse(Console.ReadLine());
            if (userTimeSheets.ContainsKey(viewUserId))
            {
                foreach (var entry in userTimeSheets[viewUserId])
                {
                    Console.WriteLine($"Date: {entry.Date.ToShortDateString()}, Hours: {entry.HoursWorked}, Description: {entry.Description}");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"User with ID {viewUserId} not found.");
            }
            Console.WriteLine();
            return;
        }
    }
}
