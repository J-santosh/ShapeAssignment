using System;
using shapesproject.Interfaces;
using shapesproject.Models;
using shapesproject.Services;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

namespace shapesproject
{
    class MainClass
    {
        public static SortedList<double, string> sortedShapes = new SortedList<double, string>();
     
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to shape object console App");
                
                // Task-2 : Calculates Area, perimeter of Circle
                CalculateCircle();

                // Task-3 : Calculates Area, perimeter alongg with type of triangle
                CalculateTriangle();

                // Task-4: Calculates Area, perimeter alongg with type of quadilateral
                CalculateQuadilateral();

                Console.WriteLine("\nsorted shapes by area (ascending) : \n");

                foreach (var item in sortedShapes)
                {
                    // Task-5: sorts sapes by Area

                    Console.WriteLine("{0} : {1}", item.Value, item.Key);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured:", e);
            }
        }

        private static void CalculateCircle()
        {
            try
            {
                const double PI = 3.14;
                var circleModel = new CircleModel();

                IShapeCircle circle = new ServiceCircle();
                Console.WriteLine("Calculating circle area and Perimeter");
                Console.WriteLine("Input radius of circle: ");
                circleModel.Radius = Convert.ToDouble(Console.ReadLine());

                //call area service
                circleModel.Area = circle.Area(circleModel.Radius, PI);
                Console.WriteLine("Area of circle for given radius is: " + circleModel.Area);

                //call circle perimeter
                circleModel.Perimeter = circle.Perimeter(circleModel.Radius, PI);
                Console.WriteLine("Perimeter of circle for given radius is: " + circleModel.Perimeter);
                SaveJson(circleModel, circleModel.Name);
                sortedShapes.Add(circleModel.Area, circleModel.Name);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured:", e);
            }
        }

        // Task-6: serialization of data and saving to disk (json format)
        private static void SaveJson(Object Model, string name)
        {
            try
            {
                string jsonString = JsonConvert.SerializeObject(Model);
                if (jsonString != null)
                {
                    Console.WriteLine("Json Object is saved to Output Folder\n");
                    File.WriteAllText(@"../../Output/" + name + DateTime.Now.ToString() + ".json", jsonString);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured:", e);
            }
        }

        private static void CalculateTriangle()
        {
            try
            {
                TriangleModel triangleModel = new TriangleModel();
                IShapeTriangle triangle = new ServiceTriangle();
                Console.WriteLine("Calculating Triangle area and Perimeter\n");
                Console.WriteLine("Input 3 sides of Triangle: \n");
                Console.WriteLine("Input side(1 of 3)");
                triangleModel.Side1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input side(2 of 3)");
                triangleModel.Side2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input side(3 of 3)");
                triangleModel.Side3 = Convert.ToDouble(Console.ReadLine());
                triangleModel.Name = triangle.Name(triangleModel.Side1, triangleModel.Side2, triangleModel.Side3);
                Console.WriteLine("The triangle is of type: " + triangleModel.Name);

                //call area service
                triangleModel.Area = triangle.Area(triangleModel.Side1, triangleModel.Side2, triangleModel.Side3);
                Console.WriteLine("Area of Triangle for given radius is: " + triangleModel.Area);

                //call circle perimeter
                triangleModel.Perimeter = triangle.Perimeter(triangleModel.Side1, triangleModel.Side2, triangleModel.Side3);
                Console.WriteLine("Perimeter of Triangle for given radius is: \n" + triangleModel.Perimeter);
                sortedShapes.Add(triangleModel.Area, triangleModel.Name);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured:", e);
            }
        }

        private static void CalculateQuadilateral()
        {
            try
            {
                QuadilateralModel quadilateralModel = new QuadilateralModel();
                IShapeQuadilateral quadilateral = new ServiceQuadilateral();
                Console.WriteLine("Calculating Triangle area and Perimeter");
                Console.WriteLine("Input length and breadth of quadilateral");
                Console.WriteLine("Input length");
                quadilateralModel.Length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input breadth");
                quadilateralModel.Breadth = Convert.ToDouble(Console.ReadLine());
                quadilateralModel.Name = quadilateral.Name(quadilateralModel.Length, quadilateralModel.Breadth);
                Console.WriteLine("The quadilateral is of type: " + quadilateralModel.Name);

                //call area service
                quadilateralModel.Area = quadilateral.Area(quadilateralModel.Length, quadilateralModel.Breadth);
                Console.WriteLine("Area of quadilateral for given sides is: " + quadilateralModel.Area);

                //call circle perimeter
                quadilateralModel.Perimeter = quadilateral.Perimeter(quadilateralModel.Length, quadilateralModel.Breadth);
                Console.WriteLine("Perimeter of quadilateral for given sides is: " + quadilateralModel.Perimeter);
                sortedShapes.Add(quadilateralModel.Area, quadilateralModel.Name);

            }

            catch (Exception e)
            {
                Console.WriteLine("Error occured:", e);
            }
        }
    }
}
