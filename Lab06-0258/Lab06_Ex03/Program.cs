Person.name = "Enter your name here";
System.Console.WriteLine(Person.GetName());

var student = new Student();
Student.name = "Enter student's name";  // ให้ใช้ชื่อคลาส Student แทนตัวแปร student
System.Console.WriteLine(Student.GetName());  // ให้ใช้ชื่อคลาส Student แทนตัวแปร student


class Person
{
    public  static  string? name;
    public  static string GetName()
    {
        return $"Hello from {name}";
    }
}

class Student : Person
{
    
}