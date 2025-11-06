using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ConsoleApp
{
    public class EmployeeRecordJSONFormat
    {
        private string _filePath;

        public EmployeeRecordJSONFormat(string filePath)
        {
            _filePath = filePath;
        }

        public void DisplayEmployeesFromFile()
        {
            var employees = ReadEmployees();

            Console.WriteLine("\nEmployee Records:");
            Console.WriteLine("-----------------------------");

            if (employees.Count == 0)
            {
                Console.WriteLine("No records found.");
                return;
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"ID: {emp.Id}");
                Console.WriteLine($"Name: {emp.Name}");
                Console.WriteLine($"DOB: {emp.DOB}");
                Console.WriteLine($"Phone: {emp.PhoneNumber}");
                Console.WriteLine("-----------------------------");
            }

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }

        private List<Employee> ReadEmployees()
        {
            if (!File.Exists(_filePath))
            {
                Console.WriteLine("JSON file not found!");
                return new List<Employee>();
            }

            string jsonContent = File.ReadAllText(_filePath);
            var employees = JsonSerializer.Deserialize<List<Employee>>(jsonContent);
            return employees ?? new List<Employee>();
        }

        // Employee model inside same class
        private class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string DOB { get; set; }
            public string PhoneNumber { get; set; }
        }
    }
}
