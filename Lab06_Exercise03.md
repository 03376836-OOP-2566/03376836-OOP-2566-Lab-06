# Lab 6 Exercise 3

## Instance vs static members

1. สร้าง console application project

```cmd
dotnet new console --name Lab06_Ex03
```

2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
Person.name = "Enter your name here";
System.Console.WriteLine(Person.GetName());
var student = new Student();
student.name = "Enter student's name";
System.Console.WriteLine(student.GetName());

static class Person
{
    static  public  string? name;
    static  public string GetName()
    {
        return $"Hello from {name}";
    }
}

class Student : Person
{
    
}
```

3. Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab06_Ex03
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3 
#### แก้ไขแล้ว
<img width="786" alt="Screenshot 2024-03-28 195027" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-06/assets/144196049/91b6156a-14bc-4241-9198-cced9a766409">

#### แก้ไข student.name เป็น Student.name
#### แก้ไข static กับ public ให้เป็น public startic
#### ลบ static ที่นำหน้า class Person ออก

5. Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab06_Ex03
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
### แก้ไขแล้ว
<img width="794" alt="Screenshot 2024-03-28 195308" src="https://github.com/SuphawadiP/03376836-OOP-2566-Lab-06/assets/144196049/db41b01b-40e1-4704-a563-9546dfd9f81e">

#### แก้ไข student.name เป็น Student.name
#### แก้ไข static กับ public ให้เป็น public startic
#### ลบ static ที่นำหน้า class Person ออก

7. อธิบายสิ่งที่พบในการทดลอง

#### โปรแกรมจะแสดงผล Hello from Enter your name here, Hello from Enter student's name
