using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


Console.Clear();
Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine($"Построчная сортировка по убывания двухмерного массива");
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
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nОтсортированный массив: ");
Console.ResetColor();
SortArrayLines(array);
ShowArray(array);
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

void SortArrayLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
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