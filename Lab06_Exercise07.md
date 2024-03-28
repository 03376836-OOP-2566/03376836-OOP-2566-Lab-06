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
<img width="796" alt="Screenshot 2024-03-28 201712" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-06/assets/144196049/10378743-904c-4a79-826b-fb99df5a2964">

#### สามารถ Build ได้ เพราะ ใช้ค่าคงที่ PI และ PI2 และเมธอด PrintCircleArea ในคลาส Circle ที่ถูกเรียกผ่านทางชื่อคลาส ซึ่งไม่มีปัญหาที่ส่งพารามิเตอร์ radius ไปยังเมธอดได้ถูกต้อง
5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex07
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="799" alt="Screenshot 2024-03-28 201756" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-06/assets/144196049/1520727c-cae6-4d3c-9811-c7bc6c8b6fff">

#### สามารถ Run ได้ปกติ เพราะ ใช้ class ได้อย่างอยู่ต้อง
7. อธิบายสิ่งที่พบในการทดลอง
#### เเสดงผลเป็น
#### Radius = 100, Area = 31415.899999999998
#### Radius = 100, Circumference = 628.318
