using System;
using System.IO;
using System.Linq;
using System.Text;

namespace BASIC
{
    internal class EmployeeAttendance
    {
        public string Name { get; set; } = string.Empty;
        public string EmployeeId { get; set; } = string.Empty;

        public EmployeeAttendance() { }

        public EmployeeAttendance(string name, string employeeId)
        {
            Name = name;
            EmployeeId = employeeId;
        }

        // File-based i.e. Add attendance to file
        public void AddAttendance(EmployeeAttendance employee, string filepath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filepath, true))
                {
                    writer.WriteLine($"Name: {employee.Name}, ID: {employee.EmployeeId}");
                }
                Console.WriteLine("Attendance added successfully to file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        /*
        // Stream-based: Add attendance to stream
        public void AddAttendance(EmployeeAttendance employee, Stream stream)
        {
            try
            {
                stream.Seek(0, SeekOrigin.End);
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8, 1024, true))
                {
                    writer.WriteLine($"Name: {employee.Name}, ID: {employee.EmployeeId}");
                }
                Console.WriteLine("Attendance added successfully to stream.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Stream Error: " + ex.Message);
            }
        }
        */

        // File-based i.e. Read all attendance records
        public void ReadAttendances(string filepath)
        {
            Console.WriteLine($"\nAttendance Records ({filepath}):");
            try
            {
                if (!File.Exists(filepath))
                {
                    Console.WriteLine("Attendance file does not exist.");
                    return;
                }

                foreach (string line in File.ReadAllLines(filepath))
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Read Error: " + ex.Message);
            }
        }

        /*
        // Stream-based: Read all attendance records from stream (optional)
        public void ReadAttendances(Stream stream)
        {
            Console.WriteLine("\nAttendance Records from stream:");
            try
            {
                stream.Seek(0, SeekOrigin.Begin);
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8, true, 1024, true))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Stream Read Error: " + ex.Message);
            }
        }
        */

        // View records by employee ID
        public void ViewByEmployeeId(string filepath, string empId)
        {
            try
            {
                if (!File.Exists(filepath))
                {
                    Console.WriteLine("Attendance file does not exist.");
                    return;
                }

                var lines = File.ReadAllLines(filepath)
                    .Where(line => line.Contains($"ID: {empId}"))
                    .ToList();

                if (lines.Count == 0)
                {
                    Console.WriteLine("No records found for Employee ID: " + empId);
                    return;
                }

                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Count total attendance entries
        public void CountEntries(string filepath)
        {
            try
            {
                if (!File.Exists(filepath))
                {
                    Console.WriteLine("Attendance file does not exist.");
                    return;
                }

                int count = File.ReadLines(filepath).Count();
                Console.WriteLine("Total attendance entries: " + count);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Delete the attendance file
        public void DeleteFile(string filepath)
        {
            try
            {
                if (File.Exists(filepath))
                {
                    File.Delete(filepath);
                    Console.WriteLine("Attendance file deleted successfully.");
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}