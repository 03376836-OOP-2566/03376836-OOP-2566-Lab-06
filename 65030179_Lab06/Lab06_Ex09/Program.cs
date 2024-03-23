Circle.PrintCircleArea(100);
class Circle
{
    static readonly double PI = 3.14159;
    public static void PrintCircleArea(double radius)
    {
        double newPI = 3.14159265359;
        System.Console.WriteLine($"Radius = {radius}, Area = {newPI * radius * radius}");
    }
}
