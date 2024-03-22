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


6. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex09
```
6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/0373c740-53aa-47f2-ada7-8c74cb99ea81)


แก้ไขโค้ดได้ผลดังนี้

โค้ด
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/cc00748b-470c-46d2-8a3e-845814a84b5b)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/418e639e-4d3a-4f11-bf8c-1ee17977a654)


![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/a75c1552-5d3c-412a-86c5-bbdbbd09a89a)



7. อธิบายสิ่งที่พบในการทดลอง

ในการทดลองดังกล่าว เราพบปัญหาที่เกิดจากการพยายามเปลี่ยนแปลงค่าของค่าคงที่ PI ซึ่งถูกประกาศด้วย const ซึ่งเป็นค่าคงที่และไม่สามารถเปลี่ยนแปลงค่าได้หลังจากกำหนดค่าไว้แล้ว

ข้อผิดพลาดที่พบคือบรรทัด PI = 3.14159265359; ที่พยายามเปลี่ยนแปลงค่าของ PI ซึ่งไม่สามารถทำได้ เนื่องจาก PI ถูกประกาศด้วย const ซึ่งทำให้ไม่สามารถเปลี่ยนแปลงค่าได้หลังจากกำหนดค่าแล้ว หลังจากแก้ไขโค้ดแล้วจะได้ผลลัพธ์ จะแสดงผลข้อมูลของ
การประกาศ PI ในคลาส Circle ด้วย private static readonly จะเป็นวิธีที่ถูกต้องและใช้งานได้ดีกว่า ซึ่งจะช่วยให้เราสามารถเปลี่ยนแปลงค่า PI และคำนวณพื้นที่ของวงกลมได้โดยไม่มีข้อผิดพลาดในโปรแกรม โดยดูผลลัพธืได้จากรูปภาพด้านบน
