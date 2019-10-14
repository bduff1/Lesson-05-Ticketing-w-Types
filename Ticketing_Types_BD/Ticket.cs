using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing_Types_BD
{
    class Ticket : ITicket
    {
        public string TicketIssue { get; set; }
        public string TicketTypeID { get; set; }
        
        public string Status { get; set; }
        public TicketType TType { get; set; }

        //private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public Ticket()
        {
            
            TType = new TicketType();
            TType.TicketTypeID = 1;
            TType.TicketTypeDesc = "Task";
            
        }

        public Ticket(string TicketTypeID, string TicketIssue, string Status)
        {
            this.TicketIssue = TicketIssue;
            this.TicketTypeID = TicketTypeID;
       
            this.Status = Status;
            TType = new TicketType();
            TType.TicketTypeID = 1;
            TType.TicketTypeDesc = "Task";

        }

        public void DisplayTicket()
        {
            Console.WriteLine(TType.TicketTypeDesc);
            Console.WriteLine("Title {0}, ID: {1}, Status: {2}", TicketIssue, TicketTypeID);
           
            
        }

        public void GetInput()
        {
            Console.WriteLine("Enter Issue/Task: ");
            this.TicketIssue = Console.ReadLine();
            Console.WriteLine("Enter Status: ");
            this.Status = Console.ReadLine();

            
            
        }
    }
}
