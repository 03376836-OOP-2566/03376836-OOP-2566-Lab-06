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
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-06/assets/144195708/15d3ca48-836e-4222-81b6-010cab8066d8)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex06
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-06/assets/144195708/4dbf573c-1aa7-47ea-87ed-fb0e099ac8be)

7. อธิบายสิ่งที่พบในการทดลอง
โปรแกรมจะแสดงผล Radius = 100, Area = 31415.899999999998
