# Lab 6 Exercise 2

## การใช้งาน Modifier


1. สร้าง console application project

```
dotnet new console --name Lab06_Ex02
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/b6084bb7-e968-4a3f-a5d0-7bce38820df6)

2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
Person.name = "Enter your name here";
System.Console.WriteLine(Person.GetName());

static class Person
{
    static public  string? name;
    static public  string GetName()
    {
        return $"Hello from {name}";
    }
}
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/e4f2256e-1cab-4120-bc5f-a85b66f37aaf)

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab06_Ex02
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง


4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/8ac7a048-7866-4423-ab0a-b4332fa55fc0)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex02
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/1f4a64af-2e79-4ca5-9478-89dd89659750)

7. อธิบายสิ่งที่พบในการทดลอง

จากการทดลองจะเห็นว่ามีผลลัพธ์ที่เหมือนกับ  Lab 6 Exercise 1 เเต่มีการเปลี่ยนแปลงของโค้ดตรงที่ 

มีการเปลี่ยนแปลงบางอย่างในการประกาศฟิลด์และเมธอดของคลาส Person

name และ GetName() ถูกประกาศเป็นสมาชิกสาธารณะ (public) โดยใช้คำว่า static public.

ฟิลด์ name และเมธอด GetName() ไม่ได้ระบุประเภทเป็น string? และ string ตามลำดับ แทนที่จะใช้ string? และ string ดังเดิม

เมธอด GetName() จะคืนค่าสตริงที่มีรูปแบบ "Hello from {name}" โดยที่ {name} จะถูกแทนที่ด้วยค่าของฟิลด์ name ที่ถูกกำหนดไว้
ในการทดลองนี้
บรรทัดแรกกำหนดค่าให้กับฟิลด์ name ให้เป็น "Enter your name here"
บรรทัดที่สองใช้เมธอด GetName() เพื่อพิมพ์ข้อความ "Hello from Enter your name here" บนคอนโซล
โดยจะเห็นว่าจะมีการแสดงผลที่เหมือนกันกับ   Lab 6 Exercise 1  ที่เป็น    Hello from Enter your name here   ดังการแสดงผลภาพด้านบน
