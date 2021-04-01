using System;
namespace shapesproject.Interfaces
{
    // Task-1: Defines quadilateral shape interface
    public interface IShapeQuadilateral
    {
        string Name(double length, double breadth);
        double Perimeter(double length, double breadth);
        double Area(double length, double breadth);
    }
}
