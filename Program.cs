using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//TICKET READING CLASS
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("", readRecord("123", "data.txt", 1)));
            Console.ReadLine();
        }
        public static void AddRecord(string ID, string name, string age, string filepath)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filepath, true))
                {
                    file.WriteLine(ID + " , " + name + " , " + age);

                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("This program failed :", ex);
            }
        }

        public static string[] readRecord(string searchTerm, string filePath, int positionOfSearchTerm)
        {
            positionOfSearchTerm--;
            string[] recordNotFound = { "Record not found" };

            try
            {
                string[] lines = System.IO.File.ReadAllLines(filePath);

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');
                    if (recordMatches(searchTerm, fields, positionOfSearchTerm))
                    {
                        Console.WriteLine("Record Found");
                        return fields;
                    }
                }
                return recordNotFound;
            }
            catch (Exception ex)
            {
                Console.WriteLine("this program malfunctioned");
                return recordNotFound;
                throw new ApplicationException("This program failed :", ex);
            }
        }
        public static bool recordMatches(string searchTerm, string[] record, int positionOfSearchTerm)
        {
            if (record[positionOfSearchTerm].Equals(searchTerm))
            {
                return true;
            }
            return false;
        }
    }
}
