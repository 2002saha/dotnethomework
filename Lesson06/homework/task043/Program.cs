using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\n Найдёт точку пересечения двух прямых");
Console.ResetColor();

Console.WriteLine("Введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Clear();

double x = (b2 - b1) / (k1 - k2);

double y = k1 * x + b1;


Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Две прямые пересекутся в точке с координатами:");
Console.ResetColor();
Console.WriteLine();
Console.WriteLine($"Х: {x}, Y: {y}");
Console.ReadKey();
Console.Clear();
