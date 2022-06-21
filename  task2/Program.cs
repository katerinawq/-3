/*Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных 
координат точек в этой четверти (x и y)*/

Console.WriteLine("Напишите номер четверти от 1 до 4");
int a = int.Parse(Console.ReadLine());

if (a==1)
{
    Console.WriteLine("x > 0 и y > 0");
}
 else if (a==2) 
 {
    Console.WriteLine("x < 0 и y > 0");
 }
 else if (a==3) 
 {
    Console.WriteLine("x < 0 и y < 0");
 }
 else if (a==4) 
 {
    Console.WriteLine("x > 0 и y < 0");
 }
 else
 {
   Console.WriteLine("Введен не верный номер");
}
 