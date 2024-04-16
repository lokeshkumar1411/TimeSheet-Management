using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetManagement
{
    public class Register
    {
        public void register(Dictionary<int, List<TimeSheetEntry>> userTimeSheets)
        {
            Console.Write("Enter User ID: ");
            int userId = int.Parse(Console.ReadLine());
            if (userTimeSheets.ContainsKey(userId))
            {
                Console.WriteLine("UserID already Registered");
                return;
            }
            else
            {
                userTimeSheets[userId] = new List<TimeSheetEntry>();
                Console.WriteLine($"User with ID {userId} added.");
                Console.WriteLine();
                return;
            }
        }

        

        

        

    }
}
