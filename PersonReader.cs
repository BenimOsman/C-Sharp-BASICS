using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASIC
{
    public class PersonReader
    {
        private string _filePath;

        public PersonReader(string filePath)
        {
            _filePath = filePath;
        }

        public void ReadPeople()
        {
            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(_filePath, FileMode.Open)))
                {
                    int count = reader.ReadInt32();

                    for (int i = 0; i < count; i++)
                    {
                        string name = reader.ReadString();
                        int age = reader.ReadInt32();

                        Console.WriteLine($"Person {i + 1}: Name = {name}, Age = {age}");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("IO Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }
        }

    }
}