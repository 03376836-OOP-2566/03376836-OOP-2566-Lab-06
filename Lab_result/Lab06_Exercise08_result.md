## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3 
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-06/assets/144196505/281520c8-c873-4c1c-98a3-04e8c9f431fb)

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-06/assets/144196505/629a99d5-33ad-4fc6-a6ab-d40416c88df6)

## อธิบายสิ่งที่พบในการทดลอง
### ไม่สามารถรันได้เนื่องจาก ประกาศค่าตัวแปร const ที่มีอยู่แล้วซ้ำลงไปซึ่งไม่สามารถทำได้
## หลังแก้ไขโค้ด โดย ประกาศตัวแปรใหม่ และ assign ค่าที่ต้องการให้กับมัน const double PI2 = PI + 0.00000265359; หรือไม่ก็ทำเป็นตัวแปรปกติตั้งแต่แรก ที่ไม่ใช่ const
```
Circle.PrintCircleArea(100);
class Circle
{
    const double PI = 3.14159;
    public static void PrintCircleArea(double radius)
    {
        const double PI2 = PI + 0.00000265359;
        System.Console.WriteLine($"Radius = {radius}, Area = {PI2 * radius * radius}");
    }
}
```
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-06/assets/144196505/e479f8de-f9dd-44c7-8e3c-fcaf0fa8c7dc)
