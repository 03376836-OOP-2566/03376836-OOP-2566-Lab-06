# Lab 6 Exercise 3

## Instance vs static members

1. สร้าง console application project

```cmd
dotnet new console --name Lab05_Ex01
```

2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
Person.name = "Enter your name here";
System.Console.WriteLine(Person.GetName());
var student = new Student();
student.name = "Enter student's name";
System.Console.WriteLine(student.GetName());

static class Person
{
    static  public  string? name;
    static  public string GetName()
    {
        return $"Hello from {name}";
    }
}

class Student : Person
{
    
}
```

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab05_Ex01
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3 

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab05_Ex01
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

7. อธิบายสิ่งที่พบในการทดลอง
