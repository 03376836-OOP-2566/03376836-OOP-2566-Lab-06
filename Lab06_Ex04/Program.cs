// See https://aka.ms/new-console-template for more information
class AAA
{
    public int b1;
    public static int b2;

    public AAA()
    {
        b1 = 10; // ตั้งค่าเริ่มต้น b1 ของ instance นี้
    }

    public static void PrintB2()
    {
        Console.WriteLine($"b2 = {b2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var a1 = new AAA();
        var a2 = new AAA();

        a1.b1 = 20; // เปลี่ยนค่า b1 ของ a1
        a2.b1 = 30; // เปลี่ยนค่า b1 ของ a2

        AAA.b2 = 40; // เปลี่ยนค่า b2

        Console.WriteLine($"a1.b1 = {a1.b1}"); // พิมพ์ 20
        Console.WriteLine($"a2.b1 = {a2.b1}"); // พิมพ์ 30
        AAA.PrintB2(); // พิมพ์ 40
    }
}
