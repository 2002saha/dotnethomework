using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


int Size; Random rand = new Random();
int[] Array;

Console.Write("Введите размер массива (не более 10): ");
Size = Convert.ToInt32(Console.ReadLine()!);
Array = new int[Size];
Console.Clear();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Исходный массив:");
Console.ResetColor();


for (int i = 0; i < Size; i++)
{
    Array[i] = rand.Next(0, 100);
    Console.Write("{0,5}", Array[i]);
}
Console.WriteLine();
int max = int.MinValue;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i] > max)
    {
        max = Array[i];
    }
}

int min = int.MaxValue;
for (int i = 0; i < Array.Length; i++)
{
    if (min > Array[i])
    {
        min = Array[i];
    }
}

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Max:  " + max);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Min:  " + min);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Разница максимального и минимального:  " + (max - min));
Console.ResetColor();
Console.WriteLine();
Console.ReadKey();
Console.Clear();