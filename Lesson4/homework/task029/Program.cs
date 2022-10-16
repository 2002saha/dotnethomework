using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Console.WriteLine("\n Вывод массива на экран");


Console.Write("Введите количество элементов массива:\t");
{


    int elementsCount = int.Parse(Console.ReadLine()!);

    int[] myArray = new int[elementsCount];

    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}:\t ");
        myArray[i] = int.Parse(Console.ReadLine()!);
    }

    Console.WriteLine("\n Вывод массива: ");

    Console.WriteLine("[{0}]", string.Join(", ", myArray));

}