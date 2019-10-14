using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing_Types_BD
{
    class TicketFile : ITicketFile
    {
        public string FilePath { get; set; }
        public char Delimiter { get; set; }
        public string SearchTerm { get; set; }

        public List<ITicket> TicketRecords { get; set; }

        //private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public TicketFile()
        {
            Delimiter = ',';
            TicketRecords = new List<ITicket>();
        }

        public void LoadFile()
        {
            using (StreamReader sr = new StreamReader(FilePath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    string[] values = line.Split(',');



                    ITicket record = new Ticket(values[2], values[1], values[0]);
                    TicketRecords.Add(record);



                    //Ticket record = new Ticket(dr["Title"].ToString(), dr["MovieID"].ToString(), genres, "1995");
                    //TicketRecords.Add(record);
                }
            }
        }

        public void WriteFile(ITicket record)
        {
            throw new NotImplementedException();
        }

        
    }
}
