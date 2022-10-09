using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Console.WriteLine("@Alexander Polezhaev");
Console.Write("Введите число до которого вывести таблицу кубов: ");

int cube = Convert.ToInt32(Console.ReadLine()); //Введеное число
void Cube(int[] cube){
  int counter = 0; //Счетчик
  int length = cube.Length; // Присвоили length массив Cube
  while (counter <  length){ // пока 
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3)); //Возведение в куб 
    counter++;
  }
}
void PrintcubeArry(int[] col){ // Вывод чисел 
  int count = col.Length; 
  int index = 1; // Чтобы вывод числе начался не с 0
  while(index < count){
    Console.Write(col[index]+ " ");
    index++;
  }
} 
int[] arry = new int[cube+1];
Cube(arry);
PrintcubeArry(arry);