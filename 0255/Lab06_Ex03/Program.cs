Person person = new Person();
person.name = "Enter your name here";
System.Console.WriteLine(person.GetName());
Student student = new Student();
student.name = "Enter student's name";
System.Console.WriteLine(student.GetName());

class Person
{
    public string? name;

    public string GetName()
    {
        return $"Hello from {name}";
    }
}

class Student : Person
{

}

