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
    class Program 
    {
        static void Main(string[] args)
        {
            List<Shape> shapeobject = new List<Shape>();

            Console.WriteLine("Geomatry Class: ");
            
            char userInput;
            do
            {
                Console.Clear();
                //print menu for user to choose from
                Console.WriteLine("A-Rectangle        E-Eclipse     I-Triangle");
                Console.WriteLine("B-Square           F-Circle      J-Tertahedon  ");
                Console.WriteLine("C-Box              G-Cylinder");
                Console.WriteLine("D-Cube             H-Sphere\n");

                //print number of shapes entered, starting with 0
                Console.WriteLine($"\n{shapeobject.Count} shapes enetered so far....\n");


                Console.Write("Choose any Input from above: ");

                

                userInput = char.Parse(Console.ReadLine().ToUpper());
                
                // Run program untill user exit the program
                //and according to the user selection, taking user data and caluclate the values and print it back to console
                switch (userInput)
                {
                    
                    case 'A': //Console.WriteLine("Rectangle Caluclation down below: ");
                        Shape rectangle = new Rectangle();
                        rectangle.SetData();
                        rectangle.CalculateArea();
                        //Console.Write(rectangle.ToString());
                        shapeobject.Add(rectangle);
                        Console.WriteLine("\n");
                        break;

                    
                    case 'B': //Console.WriteLine("Square Caluclation down below: ");
                        Shape square = new Square();
                        square.SetData();
                        square.CalculateArea();
                        //Console.Write(square.ToString());
                        shapeobject.Add(square);
                        Console.WriteLine("\n");
                        break;
                                

                    
                    case 'C': //Console.WriteLine("Box Caluclation down below: ");
                        Shape box = new Box();
                        box.SetData();
                        box.CalculateArea();
                        box.CalculateVolume();
                        //Console.WriteLine(box.ToString());
                        shapeobject.Add(box);
                        Console.WriteLine("\n");
                        break;

                    
                    case 'D': //Console.WriteLine("Cube Caluclation down below: ");
                        Shape cube = new Cube();
                        cube.SetData();
                        cube.CalculateArea();
                        cube.CalculateVolume();
                        //Console.Write(cube.ToString());
                        shapeobject.Add(cube);
                        Console.WriteLine("\n");
                        break;

                    
                    case 'E': //Console.WriteLine("Elipse Caluclation down below: ");
                        Shape elipse = new Elipse();
                        elipse.SetData();
                        elipse.CalculateArea();
                        //Console.Write(elipse.ToString());
                        shapeobject.Add(elipse);
                        Console.WriteLine("\n");
                        break;

                    
                    case 'F': //Console.WriteLine("Circle Caluclation down below: ");
                        Shape circle = new Circle();
                        circle.SetData();
                        circle.CalculateArea();
                        //Console.Write(circle.ToString());
                        shapeobject.Add(circle);
                        Console.WriteLine("\n");
                        break;

                    
                    case 'G': //Console.WriteLine("Cylinder Caluclation down below: ");
                        Shape cylinder = new Cylinder();
                        cylinder.SetData();
                        cylinder.CalculateArea();
                        cylinder.CalculateVolume();
                        //Console.Write(cylinder.ToString());
                        shapeobject.Add(cylinder);
                        Console.WriteLine("\n");
                        break;

                    
                    case 'H': //Console.WriteLine("Sphere Caluclation down below: ");
                        Shape sphere = new Sphere();
                        sphere.SetData();
                        sphere.CalculateArea();
                        sphere.CalculateVolume();
                        //Console.Write(sphere.ToString());
                        shapeobject.Add(sphere);
                        Console.WriteLine("\n");
                        break;

                    
                    case 'I': //Console.WriteLine("Triangle Caluclation down below: ");
                        Shape triangle = new Triangle();
                        triangle.SetData();
                        triangle.CalculateArea();
                        //Console.Write(triangle.ToString());
                        shapeobject.Add(triangle);
                        Console.WriteLine("\n");
                        break;

                    
                    case 'J': //Console.WriteLine("Tetrahedron Caluclation down below: ");
                        Shape tetrahedron = new Tetrahedron();
                        tetrahedron.SetData();
                        tetrahedron.CalculateArea();
                        tetrahedron.CalculateVolume();
                        //Console.Write(tetrahedron.ToString());
                        shapeobject.Add(tetrahedron);
                        Console.WriteLine("\n");
                        break;

                    case '0':
                        Console.WriteLine("\tType\t\tArea\tVolume\tDetails");
                        foreach (Shape s in shapeobject)
                        {
                            Console.WriteLine($"{s.ToString()}");
                        }
                        break;

                    
                    
                    default: Console.WriteLine("Invalid Input! please try again");
                        break;
           
                    
                }
                Console.ReadKey();
            } while(userInput!=0);
            
        }

       
    }
}
