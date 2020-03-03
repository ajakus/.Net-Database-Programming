
using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{

    public class managing
    {
        public managing()
        {
            Console.WriteLine("________TICKET_SYSTEM________");
            Console.WriteLine("(A) Add Ticket.");
            Console.WriteLine("(R) Read Tickets.");
            Console.WriteLine("(E) Exit.");
        }
        public char GetChoice()
        {
            char choice;

            Console.Write("?");
            while (!IsValidChoice(Console.ReadKey(true).KeyChar, out choice))
            {
                Console.WriteLine($"Invalid input: {choice}");
                Console.WriteLine("Retry: invalid input");
                Console.WriteLine("(A) Add Ticket.");
                Console.WriteLine("(R) Read Tickets.");
                Console.WriteLine("(E) Exit.");
                Console.Write("?");
            }
            Console.WriteLine("________");
            return choice;
        }

        private bool IsValidChoice(char input, out char choice)
        {
            char[] validChoice = { 'R', 'r', 'A', 'a', 'e', 'E' };

            choice = Char.ToUpper(input);
            if (validChoice.Contains(input))
            {
                return true;
            }

            return false;
        }
    }
}
