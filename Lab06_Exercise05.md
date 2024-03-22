# Lab 6 Exercise 5

## Static function members

1. สร้าง console application project

```cmd
dotnet new console --name Lab06_Ex05
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/f2cfeff4-2c12-4fb6-9684-7eba698c5c77)

2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
StaticDemo.i = 123;
StaticDemo.f = 1234.56f;
StaticDemo.s = "Hello World!";
StaticDemo.PrintValues();

class StaticDemo
{
    public static int  i;
    public static float f;
    public static string  s;
    public static void PrintValues()
    {
        System.Console.WriteLine($"Integer i : {i}, floating point f : {f}, string s  : {s}");
    }
}
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/5c59f587-75aa-459f-a6cb-d506d40f5874)

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab06_Ex05
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3 
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/b259048b-4de1-48d1-8bc7-0de2b1e46413)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/daf3026f-71d7-41a7-b7b0-b915a1b89650)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex05
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/cb537cfe-24c3-4b89-b62f-27874ceac1e9)

7. อธิบายสิ่งที่พบในการทดลอง

การทดลองนี้เป็นการใช้งานตัวแปรแบบ static  ซึ่งเป็นตัวแปรที่สามารถเข้าถึงได้โดยตรงผ่านชื่อของคลาส โดยไม่ต้องสร้างอ็อบเจกต์ของคลาสนั้นก่อน
StaticDemo.i = 123;: กำหนดค่าให้กับตัวแปร integer i ในคลาส StaticDemo เป็น 123
StaticDemo.f = 1234.56f;: กำหนดค่าให้กับตัวแปร float f ในคลาส StaticDemo เป็น 1234.56
StaticDemo.s = "Hello World!";: กำหนดค่าให้กับตัวแปร string s ในคลาส StaticDemo เป็น "Hello World!"
StaticDemo.PrintValues();: เรียกใช้เมธอด PrintValues() ในคลาส StaticDemo เพื่อพิมพ์ค่าของตัวแปร i, f, และ s
ผลลัพธ์ที่คาดหวังคือการพิมพ์ค่าของตัวแปร i, f, และ s ที่ถูกกำหนดค่าลงในคลาส StaticDemo ดังนี้
Integer i : 123, floating point f : 1234.56, string s  : Hello World!
ตามผลลัพน์ด้านบน
