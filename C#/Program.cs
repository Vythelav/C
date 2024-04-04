internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        //int a = 2;
        //int b = 2;
        //int c = a + b;
        //int d = a - b;
        //int g = a * b;
        //int f = a / b;
        //string One = c.ToString();
        //string Two = d.ToString();
        //string Th = g.ToString();
        //string fore = f.ToString();
        //Console.WriteLine(One + " " + Two + " " + Th + " " + fore);


        double l;
        l = Convert.ToDouble(Console.ReadLine());
        double s, r;
        r = l / (2 * 3.14);
        s = 3.14 * r * r;
        Console.WriteLine("S={0}  ", s);
    }
}