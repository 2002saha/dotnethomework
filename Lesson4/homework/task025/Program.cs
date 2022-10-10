using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


int Yournumbers(int numberA, int numberB){
  int result = 1;
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
  }
    return result;
}

  Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int resultfinal = Yournumbers(numberA, numberB);
  Console.WriteLine("Ответ: " + resultfinal);