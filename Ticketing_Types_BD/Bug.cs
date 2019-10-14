using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing_Types_BD
{
    class Bugs : ITicket
    {
        public TicketType TType { get; set; }
        public string TicketIssue { get; set; }
        public string Status { get; set; }

        public string TicketTypeID { get; set; }
        
        public string Severity { get; set; }




        public Bugs()
        {
           
            TType = new TicketType();
            TType.TicketTypeID = 3;
            TType.TicketTypeDesc = "Bug";
        }

            public void DisplayTicket()
            {
                
                Console.WriteLine(TType.TicketTypeDesc);
                Console.WriteLine("Title {0}, ID: {1}", TicketIssue, TicketTypeID);
                Console.WriteLine("Severity: {0}", Severity);
                

            }

            public void GetInput()
            {
                Console.WriteLine("Enter Title");
                this.TicketIssue = Console.ReadLine();
                Console.WriteLine("Enter Year");
                this.Status = Console.ReadLine();

               

                Console.WriteLine("Enter Severity Level");
                this.Severity = Console.ReadLine();

            }
        }
    
}