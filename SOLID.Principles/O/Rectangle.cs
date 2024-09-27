
/// <summary>
/// Open/Closed Principle (OCP)
/// Definition: Software entities should be open for extension but closed for modification.
/// </summary>
namespace SOLID.Principles.O
{
    public class Rectangle_Wrong
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public class AreaCalculator_Wrong
    {
        public double CalculateArea(Rectangle_Wrong rectangle)
        {
            return rectangle.Width * rectangle.Height;
        }
    }


    //Right
    public interface IShape
    {
        double CalculateArea();
    }

    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double CalculateArea() => Width * Height;
    }

    public class AreaCalculator
    {
        public double CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
