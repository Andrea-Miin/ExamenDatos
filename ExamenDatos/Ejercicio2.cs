using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Ejercicio2
{
    static void Main(string[] args)
    {
        // Parte a
        var a = new int[] { 1, 2, 3 };
        var b = new int[] { 1, 2 };
        IEnumerable<int> coleccion = a.Except(b);
        foreach (var i in coleccion)
        {
            Console.WriteLine(i);
        }

        // Parte b
        string query = "select [TableA].Id " +
            "from [TableA] " +
            "left join [TableB] " +
            "on [TableA].Id = [TableB].Id " +
            "where [TableB].Id is null";


        Console.ReadLine();
    }
}