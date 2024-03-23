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
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-06/assets/144195555/baf630a3-23cf-4cf5-b04b-0abe54355580)
### สามารถ Build ได้ปกติ แต่ จะถูกเตือนว่ามีค่า field ที่ถูกประกาศเป็น non-nullable (ไม่สามารถมีค่าเป็น null ได้) และไม่ได้รับค่าในตัว constructor ของ คลาส ซึ่งทำให้มีความเสี่ยงที่จะมีค่า null
5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex05
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/VisawaPRO/03376836-OOP-2566-Lab-06/assets/144195555/4842b102-a66d-4e21-9f90-a168c3329343)
### สามารถ run ได้ปกติ ไม่มีข้อผิดพลาด
7. อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมจะแสดงผล Integer i : 123, floating point f : 1234.56, string s : Hello World!
