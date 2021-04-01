using System;
using shapesproject.Interfaces;

namespace shapesproject.Services
{
    public class ServiceTriangle : IShapeTriangle
    {
        public ServiceTriangle()
        {
        }

        public double Area(double sideOne, double sideTwo, double sideThree)
        {
            try
            {
                double sidesSum = (sideOne + sideTwo + sideThree) / 2;
                return Math.Sqrt(sidesSum * (sidesSum - sideOne) * (sidesSum - sideTwo) * (sidesSum - sideThree));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public string Name(double sideOne, double sideTwo, double sideThree)
        {
            try
            {
                string triangleName = string.Empty;
                if (sideOne == sideTwo && sideTwo == sideThree)
                {
                    triangleName = "Equilaternal Triangle";
                }
                else if (sideOne == sideTwo || sideTwo == sideThree || sideThree == sideOne)
                {
                    triangleName = "Isosceles Triangle";
                }
                else triangleName = "Scalene Traingle";
                return triangleName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public double Perimeter(double sideOne, double sideTwo, double sideThree)
        {
            try
            {
                double perimeter = sideOne + sideTwo + sideThree;
                return perimeter;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
