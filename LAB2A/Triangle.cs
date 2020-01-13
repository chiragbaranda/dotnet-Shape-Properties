using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*# I, CHIRAG BARANDA, student number 000759867, 
 * certify that all code submitted is my own work; 
 * that I have not copied it from any other source.  
 * I also certify that I have not allowed my work to be copied by others.
 * 
 * Author: Chirag Baranda
 * Student Number: 000759867
 * 
 */

namespace LAB2A
{
    class Triangle : _2DShapes
    {
        public double height, basevalue;
        public override double CalculateArea()

        {
            return 0.5 * basevalue * height;
        }


        public override void SetData()
        {
            try
            {
                Type = "Triangle";
                Console.Write("Enter Base value: ");
                basevalue = double.Parse(Console.ReadLine());
                Console.Write("Enter Height: ");
                height = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Exepction!");
            }
        }

        public override string ToString()
        {
            return $"\t{Type}\t{CalculateArea()}\t{String.Empty}\t{basevalue} L X {height} W X {0.5}";
        }
    }
}
