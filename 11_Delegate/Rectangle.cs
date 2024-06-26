namespace _11_Delegate
{
    // MultiCast Delegate - A delegate that can hold the reference of more than one method.
    // A multicast delegate contains a list of methods to be called when the delegate is invoked.
    // When a multicast delegate is invoked, the delegate invokes the methods in the order in which they were added.
    // If an error occurs during the invocation of one of the methods, the invocation of the delegate stops and an exception is thrown.
    // The delegate class provides support for multicast delegate.
    // A multicast delegate is a delegate that has references to more than one functions
    public delegate void Rect(double width, double height);


    public class RectangleHelper
    {
        public static void GetArea(double width, double height)
        {
            var area = width * height;
            Console.WriteLine($"Area = {width} * {height} = {area}");
        }

        public static void GetPerimeter(double width, double height)
        {
            var perimeter = 2 * (width + height);
            Console.WriteLine($"Perimeter = 2 * ({width} + {height}) = {perimeter}");
        }
    }
}
