using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Console.ResetColor();
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine($"\nВыычисления функции Аккермана с помощью рекурсии");
Console.ResetColor();
Console.WriteLine();

int InputNumber(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

int m = InputNumber("Ввод M: ");
int n = InputNumber("Ввод N: ");
int akkermanFunction = Akkerman(m, n);

Console.Clear();
Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine($"Вычисления функции Аккермана с помощью рекурсии двух положотильных чисел - {m} и {n}:");
Console.WriteLine();
Console.ResetColor();

Console.Write($"M = {m}, N = {n} - > A(M,N) = {akkermanFunction} ");

Console.WriteLine();
Console.ReadKey();
Console.Clear();