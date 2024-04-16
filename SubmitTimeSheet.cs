using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetManagement;

namespace TimeSheetManagement
{
    public class SubmitTimeSheet
    {
        public void submitTimeSheet(Dictionary<int, List<TimeSheetEntry>> userTimeSheets)
        {
        Case2Entry:
            Console.Write("Enter User ID: ");

            int submitUserId = int.Parse(Console.ReadLine());
            if (submitUserId is int)
            {
                if (userTimeSheets.ContainsKey(submitUserId))
                {
                    Console.Write("Enter Date (any valid format): ");
                    string dateString = Console.ReadLine();
                    if (DateTime.TryParse(dateString, out DateTime date))
                    {
                        Console.Write("Enter Hours Worked: ");
                        double hoursWorked = double.Parse(Console.ReadLine());
                        if (hoursWorked is int || hoursWorked is double)
                        {
                            Console.Write("Enter Description: ");
                            string description = Console.ReadLine();


                            userTimeSheets[submitUserId].Add(new TimeSheetEntry(date, hoursWorked, description));
                            Console.WriteLine("Timesheet entry submitted successfully.");
                            Console.WriteLine();
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Enter a Valid Work Hours. Please try again.");
                            goto Case2Entry;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid date format. Please try again.");
                        goto Case2Entry;
                    }
                }
                else
                {
                    Console.WriteLine("UserId not Matched. Please Register a UserID");
                    Console.WriteLine();
                    return;
                }


            }
            else
            {
                Console.WriteLine("Enter a Valid userID");
                goto Case2Entry;
            }
        }
    }
}
