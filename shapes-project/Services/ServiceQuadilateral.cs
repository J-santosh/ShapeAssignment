using System;
using shapesproject.Interfaces;

namespace shapesproject.Services
{
    public class ServiceQuadilateral : IShapeQuadilateral
    {
        public ServiceQuadilateral()
        {
        }

        public double Area(double length, double breadth)
        {
            try
            {
                return length * breadth;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public string Name(double length, double breadth)
        {
            try
            {
                string quadilateralName = string.Empty;
                if (length == breadth)
                {
                    quadilateralName = "Square";
                }
                else quadilateralName = "Rectangle";
                return quadilateralName;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        public double Perimeter(double length, double breadth)
        {
            try
            {
                return 2 * (length + breadth);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
