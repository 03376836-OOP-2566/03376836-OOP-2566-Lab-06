## จากการทดลอง โค้ดมีข้อผิดพลาด แก้ไขดังนี้
```
ar a1 = new AAA();
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
# บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-06/assets/144195611/bef698d1-d950-46ed-b095-a47551f726fb)


# บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
D![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-06/assets/144195611/426a254d-7dbc-4681-889b-e4b02188fdb9)

# อธิบายสิ่งที่พบในการทดลอง
- จากที่โค้ดมีข้อผิดพลาดได้ทำการแก้ไขคือ เปลี่ยนตัวแปร b2 ของคลาส AAA
