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
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-06/assets/144195708/7eba3f30-9652-4576-9224-4a924b152b4a)

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3 
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-06/assets/144195708/d2e66dc2-9ecf-4f9b-89d4-79125a57667c)


5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex03
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-06/assets/144195708/b5588011-3fdc-463d-8426-89c91968d730)


7. อธิบายสิ่งที่พบในการทดลอง
- แก้ไข student.name เป็น Student.name 
 - แก้ไข static กับ public ให้เป็น public startic
