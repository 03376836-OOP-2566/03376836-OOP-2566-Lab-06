# Lab 6 Exercise 5

## Static function members

1. สร้าง console application project

```cmd
dotnet new console --name Lab06_Ex05
```

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

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab06_Ex05
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3 

<img width="530" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-06/assets/144195963/bd58b5f8-3bb9-4128-9ff5-a3f7db3ea9e2">

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex05
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="686" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-06/assets/144195963/5b4b5d82-c4bf-41b0-8914-2973b73665e7">

7. อธิบายสิ่งที่พบในการทดลอง

โปรแกรมจะแสดงผล Integer i : 123, floating point f : 1234.56, string s : Hello World!
