/*Задача 19: Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом.*/

Console.WriteLine("Введите пятизначное число");
int N = int.Parse(Console.ReadLine());

int a1 = (N / 10000);
int a2 = (N / 1000)%10;
int a4 = (N % 100)/10;
int a5 = (N % 10);

if (a1 == a5 && a2 == a4)
{
    Console.WriteLine ("Данное число палиндром");
}
else if (a1 != a5 && a2 != a4)
{
    Console.WriteLine("Данное число не палиндром");
}
else 
{
    Console.WriteLine("Введите пятизначное число");
}

/*Задача 21: Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние между
ними в 3D пространстве.*/


Console.WriteLine("Введите 1 координату точки A ");
int x1 =int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2 координату точки A");
int y1 =int.Parse(Console.ReadLine());
Console.WriteLine("Введите 3 координату точки A");
int z1 =int.Parse(Console.ReadLine());

Console.WriteLine("Введите 1 координату точки B ");
int x2 =int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2 координату точки B");
int y2 =int.Parse(Console.ReadLine());
Console.WriteLine("Введите 3 координату точки B");
int z2 =int.Parse(Console.ReadLine());

Double D = Math.Sqrt(Math.Pow(x1 - x2,2) + Math.Pow(y1 - y2,2) + Math.Pow(z1 - z2,2));
Console.WriteLine(Math.Round(D,2));

/*Задача 23: Напишите программу, которая принимает на вход 
число (N) и выдаёт таблицу кубов чисел от 1 до N.
 3 -> 1, 8, 27.
5 -> 1, 8, 27, 64, 125 */

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());

int i = 1;
while(i <= n)
{
    Console.WriteLine(Math.Pow(i,3));
    i++;
}