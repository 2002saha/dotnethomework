Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine($"Задача 1");
Console.ResetColor();
Console.WriteLine();



int Input()
{
    bool flag = false;
    int i = 0;
    while (!flag)
    {
        Console.WriteLine("\nВведите число N:");
        Console.WriteLine();
        flag = int.TryParse(Console.ReadLine(), out i);
    }
    return i;
}

int[] Filling(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
        array[i] = i + 1;
    return array;
}

void OutputString(int[] array)
{
    int summ = 1;
    while (summ != 0)
    {
        string result = string.Empty;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == 0) ;
            else
            {
                if (result.Length == 0)
                {
                    result += $"{array[i]}";
                    array[i] = 0;
                }
                else
                {
                    string[] s = result.Split(',');
                    int flag = 0;
                    for (int j = s.Length - 1; j >= 0; j--)
                    {
                        if (array[i] % Convert.ToInt32(s[j]) == 0) flag += 1;
                    }
                    if (flag == 0)
                    {
                        result += $",{array[i]}";
                        array[i] = 0;
                    }
                }
            }
        }
        Console.WriteLine(result);
        Console.WriteLine();
        summ = 0;
        for (int i = 0; i < array.Length; i++)
        {
            summ += array[i];
        }
    }
}

int[] array = Filling(Input());
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("ГРУППЫ:");
Console.WriteLine();
Console.ResetColor();
OutputString(array);


Console.ReadKey();
Console.Clear();