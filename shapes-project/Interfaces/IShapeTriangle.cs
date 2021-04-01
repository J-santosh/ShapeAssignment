using System;
namespace shapesproject.Interfaces
{
    // Task-1: Defines triangle shape interface
    public interface IShapeTriangle
    {
        string Name(double sideOne, double sideTwo, double sideThree);
        double Perimeter(double sideOne, double sideTwo, double sideThree);
        double Area(double sideOne, double sideTwo, double sideThree);
    }
}
