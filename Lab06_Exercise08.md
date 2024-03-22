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

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง
ทำการแก้ไขแล้วได้ดังนี้

โค้ด

     Circle.PrintCircleArea(100);
     class Circle
    {
     private static readonly double PI = 3.14159;

    public static void PrintCircleArea(double radius)
    {
        double updatedPI = 3.14159265359; // change PI to a more precise number.
        System.Console.WriteLine($"Radius = {radius}, Area = {updatedPI * radius * radius}");
    }
     }
Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab06_Ex08
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
   ![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/7b42c07e-7ffd-4a62-a4e0-dec75f91418e)
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/4a0bfc89-5955-4606-bd34-a409c5f1cdd1)

 Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex08
```

บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/a42c68d6-0f41-4eb8-a3a6-344278406dbf)

8. อธิบายสิ่งที่พบในการทดลอง
   
ในการทดลองนี้ เราพบปัญหาที่เกิดจากการพยายามเปลี่ยนแปลงค่าของค่าคงที่ PI ซึ่งถูกประกาศด้วย const ที่เป็นค่าคงที่และไม่สามารถเปลี่ยนแปลงค่าได้หลังจากกำหนดค่าไว้แล้ว
ข้อผิดพลาดที่พบคือบรรทัด PI = 3.14159265359; ที่พยายามเปลี่ยนแปลงค่าของ PI ซึ่งไม่สามารถทำได้ เนื่องจาก PI ถูกประกาศด้วย const ซึ่งทำให้ไม่สามารถเปลี่ยนแปลงค่าได้หลังจากกำหนดค่าแล้ว
หลังจากแก้ไขโค้ดได้แล้วคือต้องเปลี่ยนประเภทของ PI จาก const เป็น readonly ซึ่งจะอนุญาตให้เปลี่ยนแปลงค่าได้ในเมธอดของคลาสด้วยการเปลี่ยน PI เป็น private static readonly และใช้ตัวแปรใหม่ updatedPI ในการคำนวณพื้นที่ของวงกลม โค้ดจะทำงานได้ถูกต้องโดยไม่มีข้อผิดพลาดและจะแสดงผลลัพธ์ที่ถูกต้องบนหน้าจอพบปัญหาที่เกิดจากการพยายามเปลี่ยนแปลงค่าของค่าคงที่ PI ซึ่งถูกประกาศด้วย const ที่เป็นค่าคงที่และไม่สามารถเปลี่ยนแปลงค่าได้หลังจากกำหนดค่าไว้แล้ว หลังจากแก้ไขทั้งหมดแล้วจะได้ ผลลัพธ์คือการแสดงค่าพื้นที่ของวงกลมที่มีรัศมี 100 หน่วย โดยใช้ค่า PI ที่ถูกเปลี่ยนแปลงไปเป็น 3.14159265359 ออกทางหน้าจอ ดังภาพผลลัพธ์ด้านบน



