using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine($"Нахождение строки с наименьшой суммой элементов в сгенерированном массиве");
Console.ResetColor();
Console.WriteLine();
Console.WriteLine($"\nВведите размер массива m x n (столбцы и строки) и диапазон случайных значений:");
Console.WriteLine();
int columns = InputNumbers("Введите m: ");
Console.WriteLine();
int lines = InputNumbers("Введите n: ");
Console.WriteLine();
int range = InputNumbers("Введите диапазон: от 1 до ");
Console.WriteLine();
Console.Clear();

int[,] array = new int[columns, lines];
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"\nСгенерированный массив: ");
Console.ResetColor();
CreateArray(array);
ShowArray(array);


int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = SumLineElements(array, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\n{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");
Console.ResetColor();
Console.ReadKey();
Console.Clear();


int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

int SumLineElements(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}