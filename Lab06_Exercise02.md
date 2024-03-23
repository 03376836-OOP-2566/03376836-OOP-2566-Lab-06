# Lab 6 Exercise 2

## การใช้งาน Modifier


1. สร้าง console application project

```
dotnet new console --name Lab06_Ex02
```
2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
Person.name = "Enter your name here";
System.Console.WriteLine(Person.GetName());

static class Person
{
    static public  string? name;
    static public  string GetName()
    {
        return $"Hello from {name}";
    }
}
```

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab06_Ex02
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง


4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-06/assets/144195555/e8ee7630-a047-4c56-abbb-798e74941b0b)
### โปรแกรมสามารถ Build ได้เพราะไม่มีปัญหา syntax หรือ logical error ใน code
5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex02
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-06/assets/144195555/99599c5a-abec-46b0-9a8a-25ecc99a61d2)
### โปรแกรมสามารถ Run ได้เพราะไม่มีปัญหา syntax หรือ logical error ใน code
7. อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมแสดงผล Hello, World!
### การสลับ static และ public ไม่เกิดผลกระทบใด ๆ ในกรณีนี้ เนื่องจาก static ถูกใช้กับ class ทำให้ตัวแปรและเมท็อดที่อยู่ใน class นั้นสามารถเข้าถึงได้โดยไม่ต้องสร้าง instance ของ class นั้น ๆ ดังนั้นไม่ว่าจะประกาศ static ก่อนหรือหลัง public ก็ไม่มีผลต่อการทำงานของโปรแกรม
