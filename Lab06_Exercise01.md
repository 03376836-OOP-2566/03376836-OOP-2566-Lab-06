# Lab 6 Exercise 1

## การใช้งาน Modifier

1. สร้าง console application project

```cmd
dotnet new console --name Lab06_Ex01
```

2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
Person.name = "Enter your name here";
System.Console.WriteLine(Person.GetName());

static class Person
{
    public static string? name;
    public static string GetName()
    {
        return $"Hello from {name}";
    }
}
```

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab06_Ex01
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
<img width="798" alt="Screenshot 2024-03-24 153510" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-06/assets/144196049/953f7d80-f9ec-4f80-b5f8-c6611650c242">
โปรแกรมสามารถ Build ได้เพราะไม่มีปัญหา syntax หรือ logical error ใน code

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex01
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="766" alt="Screenshot 2024-03-27 165955" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-06/assets/144196049/375c31f6-18ce-4ecf-a0e7-e84201b242e8">
โปรแกรมสามารถ Run ได้เพราะไม่มีปัญหา syntax หรือ logical error ใน code

7. อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล Hello form Enter your name here สร้าง Person ที่มี Field name Method Getname() เพื่อคืนค่า "Hello from" พร้อมกับค่า name ที่กำหนด
