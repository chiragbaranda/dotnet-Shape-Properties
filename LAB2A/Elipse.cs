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
    class Elipse : _2DShapes
    {
        public double semiMajor, semiMinor;
        public override double CalculateArea()
        {
            return PI * semiMajor * semiMinor;
        }

     

        public override void SetData()
        {
            Type = "Elipse";
            Console.Write("Enter SemiMinor: ");
            semiMinor = double.Parse(Console.ReadLine());
            Console.Write("Enter SemiMajor: ");
            semiMajor = double.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"\t{Type}\t{CalculateArea()}\t{String.Empty}\t{semiMinor} L X {semiMajor} W X {PI}";
        }
    }
}
