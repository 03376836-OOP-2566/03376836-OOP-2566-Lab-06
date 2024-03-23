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

<img width="572" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-06/assets/144195963/8c30acb2-cd51-48f4-9029-7f53c3f83064">

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex08
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="551" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-06/assets/144195963/9112ebdc-100b-450d-b18f-f6d1494efaf4">

7. อธิบายสิ่งที่พบในการทดลอง


โปรแกรมจะแสดงผล Radius = 100, Area = 31415.899999999998
