# Lab 6 Exercise 3

## Instance vs static members

1. สร้าง console application project

```cmd
dotnet new console --name Lab06_Ex03
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/4cbcf5e3-81ff-4643-a4dc-49119cf22901)

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
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/6417708e-d82a-4106-8d85-a42a63302684)

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab06_Ex03
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3 
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/62c031d4-99fc-4ef2-9d2f-21acf18fc1a9)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex03
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/b80fe414-16bf-4424-8758-0f140b7b2ba9)

7. อธิบายสิ่งที่พบในการทดลอง
