Circle.PrintCircleArea(100);
class Circle
{
    const double PI = 3.14159;
    public static void PrintCircleArea(double radius)
    {
        const double PI2 = PI + 0.00000265359; // change PI to more precision number.
        System.Console.WriteLine($"Radius = {radius}, Area = {PI * radius * radius}");
    }
}