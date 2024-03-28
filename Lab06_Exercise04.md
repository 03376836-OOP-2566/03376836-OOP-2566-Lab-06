# Lab 6 Exercise 4

## Instance vs static members

1. สร้าง console application project

```cmd
dotnet new console --name Lab06_Ex04
```

2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
var a1 = new AAA();
var a2 = new AAA();
a1.b1 = 10;
AAA.b2 = 20;
a2.b1 = 30;
a2.b2 = 40;

System.Console.WriteLine($"a1.b1 = {a1.b1}");
System.Console.WriteLine($"AAA.b2 = {AAA.b2}");
System.Console.WriteLine($"a2.b1 = {a2.b1}");
System.Console.WriteLine($"a2.b2 = {a2.b2}");

class AAA 
{
    public int b1;
    public static int b2;

}
```

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab06_Ex04
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3 
#### แก้ไขแล้ว
<img width="795" alt="Screenshot 2024-03-28 200005" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-06/assets/144196049/4f9e529f-6623-4e37-ac2f-2d4c8af2ac3a">

#### ไม่สามารถ build ได้เพราะ b2 ในคลาส AAA โดยใช้อ็อบเจ็กต์ของ AAA, แต่ b2 เป็นตัวแปรสแตติก (static) ซึ่งต้องถูกเข้าถึงผ่านชื่อของคลาสตัวเองและไม่สามารถเข้าถึงได้โดยตรงจากอ็อบเจ็กต์ โดยต้องแก้ให้ a2.b2 เป็น AAA.b2
5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex04
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
#### แก้ไขแล้ว
<img width="798" alt="Screenshot 2024-03-28 200059" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-06/assets/144196049/4c4dc382-4d83-42de-aad2-a49287db213e">

#### ไม่สามารถ run ได้เพราะ b2 ในคลาส AAA โดยใช้อ็อบเจ็กต์ของ AAA, แต่ b2 เป็นตัวแปรสแตติก (static) ซึ่งต้องถูกเข้าถึงผ่านชื่อของคลาสตัวเองและไม่สามารถเข้าถึงได้โดยตรงจากอ็อบเจ็กต์ โดยต้องแก้ให้ a2.b2 เป็น AAA.b2
7. อธิบายสิ่งที่พบในการทดลอง

#### โปรแกรมจะแสดงผล a1.b1 = 10 AAA.b2 = 40 a2.b1 = 30 a2.b2 = 40
