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
    class Rectangle: _2DShapes
    {
        public double length,width;

        public override double CalculateArea()
        {
            return length * width;
        }

        public override void SetData()
        {
           
            try
            {
                Type = "Rectangle";
                Console.Write("Enter Lenght: ");
                length = double.Parse(Console.ReadLine());
                Console.Write("Enter Width: ");
                width = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("YOu, entered something wrong, please Try Again!");
            }
        }

        public override string ToString()
        {
            return $"\t{Type}\t{CalculateArea()}\t{String.Empty}\t{length} L X {width} W";
        }
    }
}
