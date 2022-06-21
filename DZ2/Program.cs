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
