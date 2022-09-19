namespace OperationsClassProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(4, 5);
            Fraction f2 = new Fraction(3, 7);
            Console.WriteLine(f1);
            Console.WriteLine(f2);

            Fraction f3 = new Fraction();
            f3 = f1 + f2 * f1;
            f3 = f1.Add(f2).Mult(f1).Del(f2) + f1;
            Console.WriteLine(f3);
        }
    }
}