# Lab 6 Exercise 1

## การใช้งาน Modifier

1. สร้าง console application project

```cmd
dotnet new console --name Lab06_Ex01
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/8ecb0707-11c4-4fb5-9c0e-330e88631a3c)

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
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/8a525aa5-1566-479e-95ae-a216e612ee5b)

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab06_Ex01
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/54b1b471-8653-475c-86a5-276d3c2e35f9)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex01
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/c2d40ac9-99eb-4452-a298-8abbf76e091c)

7. อธิบายสิ่งที่พบในการทดลอง

จากการทดลองจะเห็นว่ามี การ Run ผลของโปรแกรมออกมา ตามโค้ดที่กำหนดให้โดยโปรแกรมทำงานปกติและทำงานตามคำสั่งโค้ดดังนี้
บรรทัดแรก Person.name = "Enter your name here"; ใช้ในการกำหนดค่าให้กับตัวแปร name ที่อยู่ในคลาส Person โดยที่ค่าที่กำหนดมาคือ "Enter your name here" ซึ่งเป็นข้อความแทนชื่อของบุคคลที่เราต้องการแสดงผล

บรรทัดถัดไป System.Console.WriteLine(Person.GetName()); นั้นเป็นการเรียกใช้เมธอด GetName() ที่อยู่ในคลาส Person และแสดงผลลัพธ์ที่ได้ผ่านทาง Console

คลาส Person ถูกกำหนดเป็น static class ซึ่งหมายความว่าไม่สามารถสร้างอ็อบเจกต์ของคลาสนี้ได้ และสามารถเข้าถึงเมธอดและสมาชิกภายในคลาสได้โดยตรงโดยไม่ต้องสร้างอ็อบเจกต์ก่อน

ภายในคลาส Person มีตัวแปร name ที่ถูกประกาศเป็น public static string? ซึ่งหมายความว่า จะมีการแสดงผลทางข้อความออกมาเป็น name; และ GetName() ตามคำสั่งของโปรแกรม

เราจะเห็นว่ามีการแสดงผลทางโปรแกรมออกมาทางโค้ด เป็นดังนี้
dotnet run --project Lab06_Ex01

Hello from Enter your name here

โดยรวมแล้วเป็นการแสดงผลทางข้อความออกมา โดยใช้คำสั่งตัว Person.name   = "Enter your name here"; ใช้ในการกำหนดค่าให้กับตัวแปร name
โดยเราจะเห็นจากการเขียนคำสั่งของโปรแกรมที่แสดงผลออกมาดังภาพด้านบน

