using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing_Types_BD
{
    class EnhancementFile : ITicketFile
    {
        public char Delimiter { get; set; }
        public string FilePath { get; set; }
        public List<ITicket> TicketRecords { get; set; }

        public EnhancementFile()
        {
            TicketRecords = new List<ITicket>();
        }

        public void LoadFile()
        {
            using (StreamReader sr = new StreamReader(FilePath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    string[] values = line.Split(Delimiter);

                    Enhancements b = new Enhancements();
                    b.TicketTypeID = values[0];
                    b.TicketIssue = values[1];
                    b.Status = values[2];
                    b.Cost = values[3];
                    b.Reason = values[4];
                    
                    TicketRecords.Add(b);
                }
            }
        }

        public void WriteFile(ITicket record)
        {
            throw new NotImplementedException();
        }
    }
}
