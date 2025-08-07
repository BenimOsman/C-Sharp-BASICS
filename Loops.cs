using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASIC
{
    internal class Loops
    {
        public Loops() { }

        public void ForLoopExample()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"For Loop Value: {i}");
            }
        }

        public void WhileLoopExample()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine($"While Loop Value: {i}");
                i++;
            }
        }

        public void DoWhileLoopExample()
        {
            int i = 0;
            do
            {
                Console.WriteLine($"Do-While Loop Value: {i}");
                i++;
            } while (i < 10);
        }
    }
}
