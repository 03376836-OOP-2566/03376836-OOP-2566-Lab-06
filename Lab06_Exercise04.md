# Lab 6 Exercise 4

## Instance vs static members

1. สร้าง console application project

```cmd
dotnet new console --name Lab06_Ex04
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/6c0ebab2-9bbd-4e9c-8f89-025f007aa7da)

2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
var a1 = new AAA();
var a2 = new AAA();
a1.b1 = 10;
AAA.b2 = 20;
a2.b1 = 30;
a2.b2 = 40;

System.Console.WriteLine($"a1.b1 = {a1.b1}");
System.Console.WriteLine($"AAA.b2 = {AAA.b2}");
System.Console.WriteLine($"a2.b1 = {a2.b1}");
System.Console.WriteLine($"a2.b2 = {a2.b2}");

class AAA 
{
    public int b1;
    public static int b2;

}
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/65f4a2f5-4668-44cb-875b-5b6c3ae624d9)

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab06_Ex04
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3 
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/38814058-8b42-4a76-8685-fbc4f6e3bd2c)

![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/f6008a77-dad7-4915-bfb6-ed4d3df2d033)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex04
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/509ef08f-5eea-4a3c-9ee3-f8426a926791)

แก้ไขดค้ดได้ ดังนี้ 

    var a1 = new AAA();
    var a2 = new AAA();
    a1.b1 = 10;
    AAA.b2 = 20;
    a2.b1 = 30;
    AAA.b2 = 40;

    System.Console.WriteLine($"a1.b1 = {a1.b1}");
    System.Console.WriteLine($"AAA.b2 = {AAA.b2}");
    System.Console.WriteLine($"a2.b1 = {a2.b1}");
    System.Console.WriteLine($"AAA.b2 = {AAA.b2}");

    class AAA 
    {
       public int b1;
      public static int b2;

    }

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab06_Ex04
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3 
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/5df1680f-d437-4ddc-890f-d726061a023f)

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex04
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-06/assets/144197034/e4f769a7-bb77-4844-88b0-c98e9ffe4e9b)

7. อธิบายสิ่งที่พบในการทดลอง


