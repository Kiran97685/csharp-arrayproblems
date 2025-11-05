using System;
using System.IO;

namespace ConsoleApp
{
    public class EmployeeReader
    {
        public static void ReadFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found!");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);

            Console.WriteLine("Employee Records:");
            Console.WriteLine("-----------------------------");

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] parts = line.Split(',');

                if (parts.Length < 4)
                {
                    Console.WriteLine("Invalid data format: " + line);
                    continue;
                }

                string id = parts[0];
                string name = parts[1];
                string dob = parts[2];
                string phone = parts[3];

                Console.WriteLine($"ID: {id}");
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"DOB: {dob}");
                Console.WriteLine($"Phone: {phone}");
                Console.WriteLine("-----------------------------");
            }
        }
    }
}

