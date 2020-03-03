using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Class1
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Movie Console Application");
            Console.WriteLine("Type a number for your desired action");
            Console.WriteLine("(1) see movie list");
            Console.WriteLine("(2) add movie");
            Console.WriteLine("(3) exit program");
            String decision = Console.ReadLine();

            if (decision == "1")
            {

                String filePath = @"C:\Users\A J\Desktop\.net\ml-latest-small\movies.csv";
                List<string> lines = File.ReadAllLines(filePath).ToList();
                if (filePath == null)
                {
                    throw new FileNotFoundException();
                }
                foreach (String line in lines)
                {
                    Console.WriteLine(line);
                }
                Console.ReadLine();
            }
            if (decision == "2")
            {
                String filePath = @"C:\Users\A J\Desktop\.net\ml-latest-small\movies.csv";
                List<string> lines = File.ReadAllLines(filePath).ToList();

                Console.WriteLine("Please enter the name of the movie you would like to add: ");
                String newMovieName = Console.ReadLine();
                Console.WriteLine("Please enter the number placement of the movie: ");
                String newMovieNumber = Console.ReadLine();
                Console.WriteLine("Now enter the type of movie it is categorized as: ");
                string newMovieType = Console.ReadLine();
                String newMovie = newMovieNumber + "," + newMovieName + "," + newMovieType;
                lines.Add(newMovie);
                File.WriteAllLines(filePath, lines);
                var query = lines.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .Select(y => y.Key)
              .ToList();

            }
            else
            {
                Environment.Exit(0);
            }
        }

    }




