using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Вводим пятизначное число 
Console.Write("Введите ваше число: ");
//Указываем что введеное число это массив и присваеваем его Number
string? number = Console.ReadLine();

void CheckNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}
//Проверка количества символов 
if (number!.Length == 5){
 CheckNumber(number);
}
else Console.WriteLine($" (Ошибка 01) Число {number} не пятизначное");