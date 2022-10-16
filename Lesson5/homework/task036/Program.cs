using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

int Size, sum1 = 0; Random rand = new Random();
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
    Array[i] = rand.Next(-10, 10);
    Console.Write("{0,5}", Array[i]);
}
Console.WriteLine();

for (int i = 0; i < Size; i++)
{
    sum1 = sum1 + Array[i];
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Сумма элементов с нечетными номерами (нумерация начинается с нуля): {0} ", sum1);
Console.ResetColor();