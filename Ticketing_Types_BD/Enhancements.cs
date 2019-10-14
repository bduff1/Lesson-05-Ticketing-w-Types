using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing_Types_BD
{
    class Enhancements : ITicket
    {
        public TicketType TType { get; set; }
        public string TicketIssue { get; set; }
        public string Status { get; set; }
 
        public string TicketTypeID { get; set; }
        public string Cost { get; set; }
        public string Reason { get; set; }

        

       // private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public Enhancements()
        {
           
            TType = new TicketType();
            TType.TicketTypeID = 2;
            TType.TicketTypeDesc = "Enhancement";
            
        }
      

        public void DisplayTicket()
        {
            //logger.Trace("Displaying " + this.TicketTypeID);
            Console.WriteLine(TType.TicketTypeDesc);
            Console.WriteLine("Title {0}, ID: {1}", TicketIssue, TicketTypeID);
            Console.WriteLine("Cost: {0}", Cost);
            Console.WriteLine("Reason: {0}", Reason);
            
            
        }

        public void GetInput()
        {
            Console.WriteLine("Enter Summary/Enhancement: ");
            this.TicketIssue = Console.ReadLine();
            Console.WriteLine("Enter Status: ");
            this.Status = Console.ReadLine();

           

            Console.WriteLine("Enter Cost: ");
            this.Cost = Console.ReadLine();

            Console.WriteLine("Enter Reason: ");
            this.Reason = Console.ReadLine();

           



        }
    }
}
