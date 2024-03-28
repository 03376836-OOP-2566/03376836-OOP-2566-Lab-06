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
#### แก้ไขแล้ว
<img width="800" alt="Screenshot 2024-03-28 203157" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-06/assets/144196049/f9c44e2e-18a1-4643-aca9-093ce0d38801">

#### ไม่สามารถ Build ได้ เพราะ มีตัวแปร PI ซึ่งไม่สามารถกำหนดค่าได้ เพราะเป็นค่าเฉพาะ
5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex09
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
#### แก้ไขแล้ว
<img width="795" alt="Screenshot 2024-03-28 203314" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-06/assets/144196049/9c3b27ab-9b38-4083-9e42-1c2bf41b0f18">

#### ไม่สามารถ Run ได้ เพราะ มีตัวแปร PI ซึ่งไม่สามารถกำหนดค่าได้ เพราะเป็นค่าเฉพาะ
7. อธิบายสิ่งที่พบในการทดลอง
#### โปรแกรมจะแสดงผล Radius = 100, Area = 31415.899999999998
