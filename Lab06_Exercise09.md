# Lab 6 Exercise 9

## Change constants member value

1. สร้าง console application project

```cmd
dotnet new console --name Lab06_Ex09
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/1c672d11-0fd4-41d2-9b89-db738b8d92b3)

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
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/f458d239-0891-4453-b266-0db40d8e0cde)

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab06_Ex09
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3 
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/9c3127c3-f713-417a-9946-f07eb7fa3c91)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex09
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5




7. อธิบายสิ่งที่พบในการทดลอง
