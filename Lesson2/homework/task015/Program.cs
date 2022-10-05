Console.Write("Введи цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6 || day == 7) {
  Console.WriteLine("(этот день выходной) -> да");
  }
else if (day < 1 || day > 7) {
    Console.WriteLine("(ошибка) -> введите число от 1 до 7");
  }
else Console.WriteLine("(этот день не выходной) -> нет");


