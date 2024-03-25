// See https://aka.ms/new-console-template for more information
class Person
{
    public static string GetName(string name)  // เปลี่ยน GetName เป็น static และรับ name เป็น parameter
    {
        return $"Hello from {name}";
    }
}

class Student
{
    public string name { get; set; }  // เพิ่ม public property 'name' ให้กับ Student

    public void PrintName()  // เพิ่ม method เพื่อพิมพ์ชื่อ student
    {
        Console.WriteLine(Person.GetName(name));  // เรียก Person.GetName แบบ static และส่ง 'name' property ของ object student
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var student = new Student();
        student.name = "Alice";  // กำหนดค่าให้กับ 'name' property ของ student
        student.PrintName();  // เรียก method PrintName เพื่อพิมพ์ชื่อ student
    }
}
