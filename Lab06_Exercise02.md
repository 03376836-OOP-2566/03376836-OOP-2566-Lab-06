# Lab 6 Exercise 2

## การใช้งาน Modifier


1. สร้าง console application project

```
dotnet new console --name Lab06_Ex02
```
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

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab06_Ex02
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง


4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

<img width="547" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-06/assets/144195963/93e09b7b-a5c8-4d2a-b45e-6920a38d9e4f">

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex02
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="479" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-06/assets/144195963/24a8e96d-04fb-4712-96ef-028d8ffb8abd">

7. อธิบายสิ่งที่พบในการทดลอง
