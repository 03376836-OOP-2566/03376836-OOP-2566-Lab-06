# Lab 6 Exercise 7

## Use constance to create new constant

1. สร้าง console application project

```cmd
dotnet new console --name Lab06_Ex07
```

2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
double r = 100.0;
Circle.PrintCircleArea(r);
Circle.PrintCircleCircumference(r);
class Circle
{
    const double PI = 3.14159;
    const double PI2 = PI * 2.0;
    public static void PrintCircleArea(double radius)
    {
        System.Console.WriteLine($"Radius = {radius}, Area = {PI * radius * radius}");
    }
    public static void PrintCircleCircumference(double radius)
    {
        System.Console.WriteLine($"Radius = {radius}, Circumference = {PI2 * radius}");
    }
}
```

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab06_Ex07
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3 

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex07
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

7. อธิบายสิ่งที่พบในการทดลอง
