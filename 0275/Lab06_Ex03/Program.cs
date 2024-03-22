Person.name = "Enter your name here";
System.Console.WriteLine(Person.GetName());
var student = new Student();
student.name = "Enter student's name";
System.Console.WriteLine(student.GetName());

static class Person
{
    public static string? name;
    public static string GetName()
    {
        return $"Hello from {name}";
    }
}

class Student : Person
{
    public new static string GetName()
    {
        return $"Hello from student {name}";
    }
}
