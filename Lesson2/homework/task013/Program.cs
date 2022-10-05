using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


Console.WriteLine ("Нахождения третей цирфы в числе");


// Введем  число
Console.WriteLine("Введите число");

//Наглядно выводит третью цифру
string input = Console.ReadLine();

if (input.Length > 2){
    Console.WriteLine("Ваше число {0} -> Третья цифра {1}",input, input[2]);
}
// Если третей цифры нет, то мы выводим текст об этом
else {
  Console.WriteLine("-> третьей цифры нет, проверьте правильность ввода.");
}
