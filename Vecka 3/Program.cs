namespace Vecka_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            maxOf();
            mathOperation(10);
        }

        static void maxOf()
        {
            double value1 = 2.0;
            double value2 = 0.5;
            double value3 = (value1 * value2);
            double value4 = Math.Max(5, 10);
            double value5 = Math.Max(value1, value2);

            Console.WriteLine(value3);
            Console.WriteLine(value4);
            Console.WriteLine(value5);
        }

        static void mathOperation(double radius = 5)
        {
            double pi = 3.1416;
            double area = Math.Pow(radius, 2) * pi;

            Console.WriteLine($"The radius is {area}a.u");
        }
    }
}