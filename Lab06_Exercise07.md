# Lab 6 Exercise 7

## Use constance to create new constant

1. สร้าง console application project

```cmd
dotnet new console --name Lab06_Ex07
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/211964e7-b795-4166-aec8-88c143e36012)

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
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/5cca39c8-7f87-4bb3-ad17-817d6a163551)

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab06_Ex07
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3 
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/1952ce5c-6212-4422-a394-4dd1d05d5a65)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex07
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/83f0b288-b32b-4d88-bf48-6c971fb76f83)

7. อธิบายสิ่งที่พบในการทดลอง

การทดลองนี้ใช้คลาส Circle เพื่อคำนวณและพิมพ์ค่าพื้นที่และเส้นรอบวงของวงกลม โดยรับค่ารัศมีเป็นพารามิเตอร์ โดยมีขั้นตอนการทำงานดังนี้ 1) ประกาศค่าคงที่ PI และ PI2 เพื่อใช้ในการคำนวณเส้นรอบวงของวงกลม 2) เมธอด PrintCircleArea ใช้สำหรับคำนวณและพิมพ์ค่าพื้นที่ของวงกลม 3) เมธอด PrintCircleCircumference ใช้สำหรับคำนวณและพิมพ์ค่าเส้นรอบวงของวงกลม ผลลัพธ์ที่คาดหวังคือการแสดงค่าพื้นที่และเส้นรอบวงของวงกลมที่มีรัศมีตามที่กำหนดออกทางหน้าจอ โค้ดนี้ทำงานอย่างถูกต้อง ไม่มีการผิดพลาดทางด้านการแสดงผลของข้อมูล
