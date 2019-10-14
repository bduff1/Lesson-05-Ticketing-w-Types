using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using System.IO;
using System.Data.SqlClient;

namespace Ticketing_Types_BD
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //var entry = new MediaDB();
            string filepath = "..\\..\\ticketData.csv";

            DisplayMenu(true);
            string userSelection = Console.ReadLine().Trim();


            TicketFile ticketList = new TicketFile();

            ticketList.FilePath = filepath;

            ticketList.LoadFile();


            do
            {
                if (userSelection == "1")
                {
                    // Read and display the movies.csv file
                    int recordCount = 0;

                  // public List<ITicket> TicketRecords { get; set; }
                    
                    foreach (var ITicket in ticketList.TicketRecords)
                    {
                        recordCount++;

                        if (recordCount % 20 == 0)
                        {
                            Console.WriteLine("Display more records? Y/N");
                            string contDispl = Console.ReadLine();
                            if (contDispl.ToUpper() == "N")
                                break;
                        }
                        ITicket.DisplayTicket();
                    }
                    Console.WriteLine();
                    Console.WriteLine();

                }
                else if (userSelection == "2")
                {
                    // Add a record
                    Console.WriteLine("What type of Ticket would you like to add?");
                    Console.WriteLine("1) Task ");
                    Console.WriteLine("2) Enhancement ");
                    Console.WriteLine("3) Bug / Defect ");
                    string response = Console.ReadLine();

                    ITicket newRecord = null;
                    if (response == "1")
                    {
                        newRecord = new Ticket();
                    }
                    else if (response == "2")
                    {
                        newRecord = new Enhancements();
                    }
                    else if (response == "3")
                    {
                        newRecord = new Bugs();
                    }
                    else
                    {
                        // Bad entry
                    }
                    newRecord.GetInput();
                   // entry.AddMedia(newRecord);

                }
              
                else if (userSelection == "3")
                {
                    // end the application
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Please, Pick Another Option");
                }

                DisplayMenu(false);
                userSelection = Console.ReadLine().Trim();

            } while (userSelection != "3");
           

            Console.ReadLine();

        }

        public static void DisplayMenu(bool firstTime)
        {
            if (firstTime)
            {
                Console.WriteLine("Welcome to the Movie Library");
            }
            Console.WriteLine("1) Display Tickets");
            Console.WriteLine("2) Open a Ticket");
            Console.WriteLine("3) Exit application");
        }
        
    }
}
