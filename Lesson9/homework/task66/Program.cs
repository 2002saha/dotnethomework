using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Console.ResetColor();
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine($"\nСложение натуральных чисел в промежутке от M до N");
Console.ResetColor();
Console.WriteLine();

int InputNumber(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void PrintSum(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($" {sum} ");
        return;
    }
    PrintSum(m, n - 1, sum);

}
int m = InputNumber("Введите число M: ");
int n = InputNumber("Введите число N: ");
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}

Console.Clear();
Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine($"Cумма натуральных элементов в промежутке от {m} до {n}:");
Console.WriteLine();
Console.ResetColor();
Console.Write($"{m}, {n} ->");
PrintSum(m, n, temp = 0);

Console.WriteLine();
Console.ReadKey();
Console.Clear();
