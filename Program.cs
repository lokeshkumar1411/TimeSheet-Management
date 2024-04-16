using System;
using System.Collections.Generic;
using System.Net.Security;

namespace TimeSheetManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Register register = new Register();
            Manager managerEntry = new Manager();
            SubmitTimeSheet submitTimeSheet = new SubmitTimeSheet();
            ViweUserTimeSheet viweUserTimeSheet = new ViweUserTimeSheet();

            Dictionary<int, List<TimeSheetEntry>> userTimeSheets = new Dictionary<int, List<TimeSheetEntry>>();
            while (true)
            {
                personlabel:
                Console.WriteLine("Menu :");
                Console.WriteLine();
                Console.WriteLine("1. User");
                Console.WriteLine("2. Manager");
                Console.WriteLine("3. Exit");
                Console.WriteLine();
                Console.Write("Enter your choice: ");
                Console.WriteLine();
                int person = int.Parse(Console.ReadLine());

                //user

                if (person == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("1. Register User");
                        Console.WriteLine("2. Submit Timesheet");
                        Console.WriteLine("3. View Timesheet");
                        Console.WriteLine("4. Menu");
                        Console.Write("Enter your choice: ");
                        int choice = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        switch (choice)
                        {
                            case 1:
                                register.register(userTimeSheets);
                                break;

                            case 2:
                                submitTimeSheet.submitTimeSheet(userTimeSheets);
                                break;


                            case 3:
                                viweUserTimeSheet.ViewUserTimeSheet(userTimeSheets);
                                break;

                            case 4:
                                Console.WriteLine("Thanks for the Submission. Have a Nice Day.");
                                goto personlabel;


                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                Console.WriteLine();
                                break;
                        }

                    }
                }

                //manager

                else if (person == 2)
                {
                    while (true)
                    {
                        Console.WriteLine("1. View User Details");
                        Console.WriteLine("2. View All Timesheet Entries");
                        Console.WriteLine("3. Menu");
                        Console.Write("Enter your choice: ");
                        int Managerchoice = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        switch (Managerchoice)
                        {
                            case 1:
                                viweUserTimeSheet.ViewUserTimeSheet(userTimeSheets);
                                break;

                            case 2:
                                managerEntry.ViewAllTimeSheets(userTimeSheets);
                                break;

                            case 3:
                                Console.WriteLine("Thanks. Have a Nice Day.");
                                Console.WriteLine();
                                goto personlabel;
                        }
                    }
                }

                else if (person == 3)
                {
                    Console.WriteLine("Thanks. Have a Nice Day.");
                    Console.WriteLine();
                    Environment.Exit(0);
                }

                //invalid choice

                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.WriteLine();

                }
            }
            
            
            
        }
    }

    

    
}
