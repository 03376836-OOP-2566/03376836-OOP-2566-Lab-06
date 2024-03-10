## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3 
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-06/assets/144196505/1df5176f-a409-4a82-abae-98cbd7456d06)

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-06/assets/144196505/72bce12e-4ce3-4a84-b378-9b7163e3657a)

## อธิบายสิ่งที่พบในการทดลอง
### รันไม่ได้เนื่องจาก โปรแกรมไม่รู้จักตัวแปร name ควรให้ name เป็น instance แทนที่จะเป็น static
### instance members  = field, constructor, method ที่ไม่ใช่ static
### Static members = static class, static method

## แก้ไขโค้ดโดย ทำให้เป็น instance แทน static
```
Person person = new Person();
person.name = "Enter your name here";
System.Console.WriteLine(person.GetName());
Student student = new Student();
student.name = "Enter student's name";
System.Console.WriteLine(student.GetName());

class Person
{
    public string? name;

    public string GetName()
    {
        return $"Hello from {name}";
    }
}

class Student : Person
{

}
```
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-06/assets/144196505/546a3399-c086-4397-9e4d-c7beb9d28c7f)
