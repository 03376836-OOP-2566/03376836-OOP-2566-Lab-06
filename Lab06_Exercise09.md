# Lab 6 Exercise 9

## Change constants member value

1. สร้าง console application project

```cmd
dotnet new console --name Lab06_Ex09
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
dotnet build  Lab06_Ex09
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3 

![9](https://github.com/Siriratda/03376836-OOP-2566-Lab-06/assets/144195995/84de1cbd-477d-4ee2-8145-2ed0bda61079)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex09
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![9 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-06/assets/144195995/336c4487-19df-410c-9097-e8a38fdad420)

7. อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล Radius = 100, Area = 31415.899999999998
