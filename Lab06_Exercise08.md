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
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-06/assets/144195708/3ac2b0af-b110-4e5b-af8f-3f2b1d0cbe3a)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex08
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-06/assets/144195708/af758bf4-5e6a-47f1-b11a-edc0ab5b2694)
ไม่สามารถ Run ได้ เพราะ มีตัวแปร PI ซึ่งไม่สามารถกำหนดค่าได้ เพราะเป็นค่าเฉพาะ

8. อธิบายสิ่งที่พบในการทดลอง
โปรแกรมจะแสดงผล Radius = 100, Area = 31415.899999999998
