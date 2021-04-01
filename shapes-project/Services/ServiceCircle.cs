using System;
using shapesproject.Interfaces;

namespace shapesproject.Services
{
    public class ServiceCircle : IShapeCircle
    {
        public ServiceCircle()
        {
        }

        public double Area(double radius, double PI)
        {
            try
            {
                double area;
                area = PI * radius * radius;
                return area;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        
        public double Perimeter(double radius, double PI)
        {
            try
            {
                double perimeter;
                perimeter = 2 * PI * radius;
                return perimeter;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}