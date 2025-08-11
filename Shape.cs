using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASIC
{
    internal class Shape<T>                         // This is a generic class with a type parameter <T>
    {
        private T shapeName;                        // To store the shape (of Type T)
            
        public Shape()
        {
            shapeName = default(T);                 // Initialize shapeName with default value
        }

        public Shape(T name)
        {
            shapeName = name;                       // Initialize shapeName with provided name
        }

        public T ShapeName
        {
            get { return shapeName; }               // Getter to access shapeName
            set { shapeName = value; }              // Setter to update shapeName
        }

        public override string ToString()
        {
            return $"Shape Name: {shapeName}";      // Override ToString to return shape name
        }
    }
}
