# Lab 6 Exercise 8

## Change constants member value

1. สร้าง console application project

```cmd
dotnet new console --name Lab06_Ex08
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/4fe4a80e-d553-41b6-99f6-5bc5c5ab3cee)

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
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/808808d0-7c19-4b56-a553-6d59184f1629)

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab06_Ex08
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3 
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/f2bfda66-1a5c-4b31-afa4-0787565eff06)


5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex08
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/cf3d7927-44c0-4b3e-b24d-57dd14014bed)
7. อธิบายสิ่งที่พบในการทดลอง
