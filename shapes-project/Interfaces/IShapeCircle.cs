using System;
namespace shapesproject.Interfaces
{
    // Task-1: Defines circle shape interface
    public interface IShapeCircle
    {
        double Perimeter(double radius, double PI);
        double Area(double radius, double PI);
    }
}
