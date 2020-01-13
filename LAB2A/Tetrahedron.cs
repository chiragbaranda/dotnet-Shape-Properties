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
    class Tetrahedron : _3DShapes
    {
        public double length;
        public override double CalculateArea()
        {
            return 1.732 * length;
        }

        public override double CalculateVolume()
        {
            return (length *length * length) / 8.485;
        }

        public override void SetData()
        {

            try
            {
                Type = "Cube";
                Console.Write("Enter Lenght of side of TetraHedron: ");
                length = double.Parse(Console.ReadLine());

            }
            catch
            {
                Console.WriteLine("Exepction!");
                length = double.Parse(Console.ReadLine());
            }
        }

        public override string ToString()
        {
            return $"\t{Type}\t{String.Empty}\t{CalculateVolume()}\t {length} L X {length} L X {length} L / {8.485}";
        }
    }
}
