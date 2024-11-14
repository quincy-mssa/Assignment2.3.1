using System.IO;

namespace Assignment2._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\quinc\OneDrive\Documents\Assignment 2.3.1 MSSA.txt";

            //List<string> lines = File.ReadAllLines(filePath).ToList();

            //foreach (string line in lines)

            //    {
            //        Console.WriteLine(line);

            //    }

            //lines.Add("Gianna Bryant, 2 Mamba Way");

            //File.WriteAllLines(filePath, lines);

            List<Person> people = new List<Person>();

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');

                Person newPerson = new Person();

                newPerson.FirstName = entries[0];
                newPerson.LastName = entries[1];
                newPerson.Address = entries[2];

                people.Add(newPerson);
            }
            foreach (var person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}: {person.Address}");
            }

            people.Add(new Person { FirstName = "Paul", LastName = "Walker", Address = "2 Fast and Furious Street" });

            List<string> output = new List<string>();

            foreach (var person in people) 
            {
            output.Add($"{person.FirstName}, {person.LastName}, {person.Address}");
            }

            Console.WriteLine("Writing to text file");

            File.WriteAllLines(filePath, output);

            Console.WriteLine("All entries written");

            Console.ReadLine();

        }
    }
}
