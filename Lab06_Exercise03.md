# Lab 6 Exercise 3

## Instance vs static members

1. สร้าง console application project

```cmd
dotnet new console --name Lab06_Ex03
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
dotnet build  Lab06_Ex03
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3 

![3](https://github.com/Siriratda/03376836-OOP-2566-Lab-06/assets/144195995/5c040f6b-b7db-49a7-a5d6-fb07bb2bc9ea)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex03
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![3 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-06/assets/144195995/b8f64635-3658-4843-96bd-9832b62f5901)

7. อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล Hello from Enter your name here, Hello from Enter student's name
