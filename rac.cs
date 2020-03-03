using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//TICKET WRITING CLASS
namespace Tickets
{

    class Program
    {
        static void Main(string[] args)
        {
            string fileTickets = "data.txt";


            do
            {

                if (select == "2")
                {
                string recOne = "1,This is a bug ticket,Open,High,Drew Kjell,Jane Doe,Drew Kjell,John Smith,Bill Jones";
                int ticketID = 1;
                string summary = " ";
                string status = " ";
                string priority = " ";
                string submitter = " ";
                string assigned = " ";
                string watching = " ";
                string ans = "Y";

                // load header and first record

                StreamWriter sw = new StreamWriter(fileTickets);
                sw.WriteLine(recOne);


                //ask questions till 'N' and write record with the data


                do
                {
                    //ask the question
                    Console.WriteLine("Would you like to enter a ticket (Y/N)?");
                    string resp = Console.ReadLine().ToUpper();
                    if (resp == "N") { break; }
                    ticketID += 1;
                    // prompt for Ticket info

                    do
                    {
                        Console.WriteLine("Enter the Ticket Summary:");
                        // save the course name
                        summary = Console.ReadLine().ToUpper();
                        if (summary == "")
                        {
                            Console.WriteLine("\t**Must enter something");

                        }
                    }
                    while (summary == " ");
                    // 

                    do
                    {
                        Console.WriteLine("What is the status of the ticket? Open or Closed");
                        // save the course name
                        status = Console.ReadLine().ToUpper();
                        if (status != "OPEN" && status != "CLOSED")
                        {
                            Console.WriteLine("\t**Must enter open or closed");

                        }
                    }
                    while (status != "OPEN" && status != "CLOSED");
                    //
                    do
                    {
                        Console.WriteLine("Priority High, Medium or Low?");
                        // save the course name
                        priority = Console.ReadLine().ToUpper();
                        if (priority != "HIGH" && priority != "MEDIUM" && priority != "LOW")
                        {
                            Console.WriteLine("\t**Must enter HIGH, MEDIUM or LOW");

                        }
                    }
                    while (priority != "HIGH" && priority != "MEDIUM" && priority != "LOW");
                    //
                    do
                    {
                        Console.WriteLine("Enter submitter name:");
                        // save the course name
                        submitter = Console.ReadLine().ToUpper();
                        if (submitter == "")
                        {
                            Console.WriteLine("\t**Must enter a name");

                        }
                    }
                    while (submitter == " ");
                    //
                    do
                    {
                        Console.WriteLine("Enter assigned to name:");
                        // save the course name
                        assigned = Console.ReadLine().ToUpper();
                        if (assigned == "")
                        {
                            Console.WriteLine("\t**Must enter an assigned to name");

                        }
                    }
                    while (assigned == " ");
                    //
                    do
                    {
                        Console.WriteLine("Enter watching name:");
                        // save the course name
                        watching = Console.ReadLine().ToUpper();
                        if (watching == "")
                        {
                            Console.WriteLine("\t**Must enter a watching name");

                        }
                    }
                    while (watching == " ");
                    //write the record
                    sw.WriteLine("{0},{1},{2},{3},{4},{5},{6}", Convert.ToInt32(ticketID), summary, status, priority, submitter, assigned, watching);
                }
                while (ans == "Y");

                sw.Close();
                }
            }
            while (select == "1");

        }
    }
}
