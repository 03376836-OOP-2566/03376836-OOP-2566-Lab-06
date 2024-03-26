# Lab 6 Exercise 4

## Instance vs static members

1. สร้าง console application project

```cmd
dotnet new console --name Lab06_Ex04
```

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

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab06_Ex04
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
   ![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-06/assets/144195708/7a079038-d59d-4a27-b45a-8f17806e3b38)


5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex04
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-06/assets/144195708/e13f603f-6cbc-4ca4-8794-660deaeed9f9)

7. อธิบายสิ่งที่พบในการทดลอง
โปรแกรมจะแสดงผล a1.b1 = 10 AAA.b2 = 40 a2.b1 = 30 a2.b2 = 40
