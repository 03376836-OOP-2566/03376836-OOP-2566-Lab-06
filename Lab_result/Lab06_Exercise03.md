## โค้ดมีข้อผิดพลาด มีการแก้ไขโค้ด
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
# บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-06/assets/144195611/5d0af73a-8d7e-4b0d-ac86-a0c5c3a27709)

# บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-06/assets/144195611/72cd31e4-0243-4275-ac48-e6afb1df283a)


# อธิบายสิ่งที่พบในการทดลอง
- เปลี่ยนจาก nameที่เป็น static เป็น instance และโค้ดเดิมไม่สามารถสืบทอดได้เนื่องจากเป็น static class จึงต้องมีการแก้ไขโค้ด 
