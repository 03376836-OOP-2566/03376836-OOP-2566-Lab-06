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
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-06/assets/144195708/83ec5400-e656-4d24-92a8-db689c001765)

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3 
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-06/assets/144195708/0e9372e3-a5bc-416e-be94-79d9521a34a7)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex09
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-06/assets/144195708/ded37dbf-9185-43da-93d5-067647f45e83)

7. อธิบายสิ่งที่พบในการทดลอง
โปรแกรมจะแสดงผล Radius = 100, Area = 31415.899999999998
