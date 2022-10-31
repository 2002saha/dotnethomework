using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Простите, что много оформления....

Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("\nНахождение среднего арифметического каждых элемтнов столбцов в сгенерированном массиве");
Console.ResetColor();
Console.WriteLine();
Console.WriteLine("\nВведите размеры массива желаемого массива (M - строки, N - столбцы):");
Console.ResetColor();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("M: ");
Console.WriteLine();
Console.ResetColor();
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("N: ");
Console.WriteLine();
Console.ResetColor();
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int[,] array = new int[m, n];
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"\nСгенерированный массив: ");
Console.ResetColor();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = Convert.ToInt32(new Random().Next(0, 50));
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + "\t  ");
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < array.GetLength(1); i++)
{
    int srAr = 0;
    int ColChetn = 0;
    for (int t = 0; t < 3; t++)
    {
        srAr += array[t, i];
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1}: ");
    Console.ResetColor();
    Console.WriteLine($"{(float)srAr / 3}");
}

Console.ResetColor();
Console.WriteLine();
Console.ReadKey();
Console.Clear();
Console.Clear();