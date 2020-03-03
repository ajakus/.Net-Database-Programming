using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TicketOOP.Models
{
    public class TicketFile
    {
        public List<Ticket> Contents { get; }
        private readonly string _filename = Path.Combine(Environment.CurrentDirectory, "Files", "tickets.txt");

        public TicketFile()
        {
            if (!Validate()) throw new FileNotFoundException($"Unable to locate {_filename}");

            Contents = ReadFile();
        }

        public bool Validate()
        {
            if (File.Exists(_filename))
            {
                return true;
            }

            return false;
        }

        private List<Ticket> ReadFile()
        {
            List<Ticket> tickets = new List<Ticket>();
            string[] lines = File.ReadAllLines(_filename);

            foreach (var line in lines)
            {
                var id = line.Split(',')[0];
                var name = line.Split(',')[1];
                tickets.Add(new Ticket() { Id = id, Name = name });
            }

            return tickets;
        }

        public void WriteFile(Ticket ticket)
        {
            var sw = new StreamWriter(_filename);
            Contents.Add(ticket);
            Contents.ForEach(c => sw.WriteLine($"{c.Id},{c.Name}"));
            sw.Flush();
            sw.Close();
        }

    }
}
