Person Person = new Person();
Person.name = "Ping";
System.Console.WriteLine(Person.GetName());
var student = new Student();
student.name = "Milk";
System.Console.WriteLine(student.GetName());

 class Person
{
      public  string? name;
      public string GetName()
    {
        return $"Hello from {name}";
    }
}

class Student : Person
{
    
}