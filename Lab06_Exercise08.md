# Lab 6 Exercise 8

## Change constants member value

1. สร้าง console application project

```cmd
dotnet new console --name Lab06_Ex08
```

2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
Circle.PrintCircleArea(100);
class Circle
{
    const double PI = 3.14159;
    public static void PrintCircleArea(double radius)
    {
        PI = 3.14159265359; // change PI to more precision number.
        System.Console.WriteLine($"Radius = {radius}, Area = {PI * radius * radius}");
    }
}
```

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab06_Ex08
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3 

![8](https://github.com/Siriratda/03376836-OOP-2566-Lab-06/assets/144195995/fa1f2781-8c47-4fbe-a5ae-4026b92c4d2a)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex08
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![8 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-06/assets/144195995/0a6b073d-0388-4d62-8b58-f22f4bc34538)

7. อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล Radius = 100, Area = 31415.899999999998
