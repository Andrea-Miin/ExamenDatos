using System;

using System;

public class Ejercicio6
{
    static void Main(string[] args)
    {
        // Parte a
        var a = 5;
        var b = 10;
        Func<int> suma = (() => a + b);
        Func<int> mult = (() => a * b);
        Console.WriteLine(suma());
        Console.WriteLine(mult());
        // Parte b
        Console.WriteLine(Operation.Suma(a, b));
        Console.WriteLine(Operation.Mult(a, b));

        Console.ReadLine();
    }
    class Operation
    {
        public static int Suma(int x, int y)
        {
            var suma = x + y;
            return suma;
        }
        public static int Mult(int x, int y)
        {
            var mult = x * y;
            return mult;
        }
    }
}
