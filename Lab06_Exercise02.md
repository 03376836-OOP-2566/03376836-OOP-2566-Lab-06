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
<img width="797" alt="Screenshot 2024-03-27 170612" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-06/assets/144196049/16b77647-0948-4bf6-9282-c96b1a94b5c5">
โปรแกรมสามารถ Build ได้เพราะไม่มีปัญหา syntax หรือ logical error ใน code

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex02
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="798" alt="Screenshot 2024-03-27 170654" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-06/assets/144196049/53fa17c3-20b7-4a2a-94e5-5a65a6f7b436">
โปรแกรมสามารถ Run ได้เพราะไม่มีปัญหา syntax หรือ logical error ใน code

7. อธิบายสิ่งที่พบในการทดลอง

การสลับ static และ public ไม่เกิดผลกระทบใด ๆ ในกรณีนี้ เนื่องจาก static ถูกใช้กับ class ทำให้ตัวแปรและเมท็อดที่อยู่ใน class นั้นสามารถเข้าถึงได้โดยไม่ต้องสร้าง instance ของ class นั้น ๆ ดังนั้นไม่ว่าจะประกาศ static ก่อนหรือหลัง public ก็ไม่มีผลต่อการทำงานของโปรแกรม
