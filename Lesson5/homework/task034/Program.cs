using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Проверяющему всего самого наилучшего!

Console.WriteLine("Введите размер желаемого массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int[] numbers = new int[size];
FillArrayRandom(numbers);

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Сгенерированный массив: ");
Console.ResetColor();

PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
    if (numbers[z] % 2 == 0)
        count++;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Всего {numbers.Length} чисел, {count} из них чётные");
Console.ResetColor();


void FillArrayRandom(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}