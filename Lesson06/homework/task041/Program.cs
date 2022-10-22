using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Проверяющему всего самого наилучшего!

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\n Вывод количества чисел > 0 в массиве");
Console.ResetColor();

Console.Write("Введите количество элементов массива:\t");
{


    int elementsCount = int.Parse(Console.ReadLine()!);

    int[] myArray = new int[elementsCount];

    for (int i = 0; i < myArray.Length; i++)
    {

        Console.Write($"Введите элемент массива под индексом {i}:\t ");
        myArray[i] = int.Parse(Console.ReadLine()!);
    }
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\n Ваш массив: ");
    Console.ResetColor();
    Console.WriteLine();
    Console.WriteLine("[{0}]", string.Join(", ", myArray));
    int count = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Кол-во элементов > 0:");
    Console.ResetColor();
    Console.WriteLine();
    Console.WriteLine($"{count}");
    Console.WriteLine();
    Console.ReadKey();
    Console.Clear();
}
