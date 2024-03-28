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
<img width="795" alt="Screenshot 2024-03-28 201241" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-06/assets/144196049/97e20965-4446-4b92-b6f8-5cc72ef877a8">

#### สามารถ Build ได้ปกติ เพราะ ใช้ค่าคงที่ PI และเมธอด PrintCircleArea ในคลาส Circle ที่ถูกเรียกผ่านทางชื่อคลาส ซึ่งไม่มีปัญหาที่ส่งพารามิเตอร์ radius ไปยังเมธอดได้ถูกต้อง
5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex06
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="802" alt="Screenshot 2024-03-28 201430" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-06/assets/144196049/4d095085-807a-48a8-b1c0-9472c40763fd">

#### สามารถ Run ได้ปกติ เพราะ ใช้ class ได้อย่างอยู่ต้อง
7. อธิบายสิ่งที่พบในการทดลอง
#### โปรแกรมจะแสดงผล Radius = 100, Area = 31415.899999999998
