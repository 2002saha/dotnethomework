using System;

Console.WriteLine("Start");
// Введите два числа после a = , b = , c =
int a = 2;
int b = 3;
int c = 7;
int max = a; 


if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}

Console.WriteLine ("Максимальное значение - " + max);

Console.WriteLine ("End");