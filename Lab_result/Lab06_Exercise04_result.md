## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3 
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-06/assets/144196505/42e3ea10-322a-4d62-a5e1-71d0de17bbb8)

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-06/assets/144196505/1c3f62d2-ceb9-48a0-9b4b-f7623c68b194)

## อธิบายสิ่งที่พบในการทดลอง
### ไม่สามารถรันได้เนื่องจากมีการใช้ตัวแปรแบบ static (b2) ในคลาส AAA และมีการเข้าถึง b2 ผ่าน instance a2 จึงเข้าถึงไม่ได้ ตัวแปร static (b2) ควรถูกเข้าถึงโดยคลาส AAA

## แก้โค้ดโปรแกรม โดยแก้ a2.b2 = 40 เป็น AAA.b2 = 40
```
var a1 = new AAA();
var a2 = new AAA();
a1.b1 = 10;
AAA.b2 = 20;
a2.b1 = 30;
AAA.b2 = 40;

System.Console.WriteLine($"a1.b1 = {a1.b1}");
System.Console.WriteLine($"AAA.b2 = {AAA.b2}");
System.Console.WriteLine($"a2.b1 = {a2.b1}");
System.Console.WriteLine($"a2.b2 = {AAA.b2}");

class AAA 
{
    public int b1;
    public static int b2;

}
```
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-06/assets/144196505/03c785fa-a35e-4b25-a9ce-8dd4de6c203d)
