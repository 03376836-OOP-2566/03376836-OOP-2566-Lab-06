# Lab 6 Exercise 6

## Member constants

1. สร้าง console application project

```cmd
dotnet new console --name Lab06_Ex06
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/697b74a8-1619-48e2-b7e4-ea5d30d55517)

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
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/d6267612-7d15-4f2b-94ef-b55f0811c9ed)

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab06_Ex06
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3 
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/a92b9be5-8083-4080-b8f3-8049a4d1fa02)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex06
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/edba0130-2885-4ec9-be79-138f011de1b0)

7. อธิบายสิ่งที่พบในการทดลอง
