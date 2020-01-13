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
    class Cylinder : _3DShapes
    {
        public double radius, height;
        public override double CalculateArea()
        {
            return 2 * PI * radius * (radius + height);
        }

        public override double CalculateVolume()
        {
            return PI * radius *radius * height;
        }

        public override void SetData()
        {
            try
            {
                Type = "Cylinder";
                Console.Write("Enter Radius: ");
                radius = double.Parse(Console.ReadLine());
                Console.Write("Enter height: ");
                height = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Exepction!");
            }
        }

        public override string ToString()
        {
            return $"\t{Type}\t{String.Empty}\t{CalculateVolume()}\t {PI} X ({radius} R X {radius} W X {height})";
        }
    }
}
