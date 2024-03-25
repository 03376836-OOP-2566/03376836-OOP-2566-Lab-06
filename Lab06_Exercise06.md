# Lab 6 Exercise 6

## Member constants

1. สร้าง console application project

```cmd
dotnet new console --name Lab06_Ex06
```

2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
Circle.PrintCircleArea(100);

class Circle
{
    const double PI = 3.14159;
    public static void PrintCircleArea(double radius)
    {
        System.Console.WriteLine($"Radius = {radius}, Area = {PI * radius * radius}");
    }
}
```

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab06_Ex06
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3 

![6](https://github.com/Siriratda/03376836-OOP-2566-Lab-06/assets/144195995/a9125f0c-ace4-4bbf-8089-91247c550b85)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex06
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![6 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-06/assets/144195995/e2d6949b-b73e-4edb-be14-6f0ffe8a9223)

7. อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล Radius = 100, Area = 31415.899999999998
