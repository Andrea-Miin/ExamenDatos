using System;

public class Ejercicio3
{
    public Class1()
    {
        int[] lista = new int[20];

        Console.WriteLine("Pares: ");
        for (int x = 0; x <= lista.Length; x++)
        {
            if (Operation.EsPar(x) == true)
            {
                Console.WriteLine(x);
            }
        }

        Console.WriteLine("Mayores de 10: ");
        for (int x = 0; x <= lista.Length; x++)
        {
            if (Operation.EsMayor(x) == true)
            {
                Console.WriteLine(x);
            }
        }

        Console.WriteLine("Menores de 10: ");
        for (int x = 0; x <= lista.Length; x++)
        {
            if (Operation.EsMenor(x) == true)
            {
                Console.WriteLine(x);
            }
        }
        Console.ReadLine();

    }
    class Operation
    {
        public static bool EsPar(int value)
        {
            return value % 2 == 0;
        }
        public static bool EsMayor(int value)
        {
            return value > 10;
        }
        public static bool EsMenor(int value)
        {
            return value < 10;
        }
    }
}
