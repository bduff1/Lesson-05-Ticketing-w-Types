using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing_Types_BD
{
    interface ITicket
    {
        TicketType TType { get; set; }
        string TicketIssue { get; set; }
        string Status { get; set; }
        
        string TicketTypeID { get; set; }
        
        void DisplayTicket();
        void GetInput();
    }
}
