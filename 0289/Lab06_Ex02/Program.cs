// See https://aka.ms/new-console-template for more information
Person.name = "Enter your name here";
System.Console.WriteLine(Person.GetName());

static class Person
{
    static public  string? name;
    static public  string GetName()
    {
        return $"Hello from {name}";
    }
}
