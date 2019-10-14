using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing_Types_BD
{
    class BugFile : ITicketFile
    {
        public char Delimiter { get; set; }
        public string FilePath { get; set; }
        public List<ITicket> TicketRecords { get; set;  }

        public void LoadFile()
        {
            using (StreamReader sr = new StreamReader(FilePath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    string[] values = line.Split(',');

                   
                }
            }
        }

        public void WriteFile(ITicket record)
        {
            throw new NotImplementedException();
        }
    }
}
