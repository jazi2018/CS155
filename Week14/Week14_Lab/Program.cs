using static Week14_Lab.Rectangle;

namespace Week14_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            //rect.area(6.3, 4.2);
            rectDelegate rectDele = new rectDelegate(rect.area);
            rectDele += rect.perimeter;
            rectDele.Invoke(6.3, 4.2);
        }
    }

    public class Rectangle
    {
        public delegate void rectDelegate(double height, double width);
        public void area(double height, double width)
        {
            Console.WriteLine("Area is: {0}", (width * height));
        }
        public void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is: {0}", 2 * (width + height));
        }
    }
}
