using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing_Types_BD
{
    interface ITicketFile
    {
        char Delimiter { get; set; }
        string FilePath { get; set; }

        List<ITicket> TicketRecords { get; set; }

        void LoadFile();
        void WriteFile(ITicket record);
    }
}
