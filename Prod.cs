using System;

namespace BASIC 
{
    public class Prod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime ManFDate { get; set; }

        public Prod(int id, string name, double price, DateTime manFDate)
        {
            Id = id;
            Name = name;
            Price = price;
            ManFDate = manFDate;
        }

        public override string ToString()
        {
            return $"Product[ID={Id}, Name={Name}, Price={Price}, Manufactured Date={ManFDate:yyyy-MM-dd}]";
        }
    }
}