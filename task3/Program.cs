/*Напишите программу, которая принимает на вход координаты
 двух точек и находит расстояние между ними в 2D пространстве.
 
A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21
*/

/*Console.WriteLine("Введите число");
double a = double.Parse(Console.ReadLine());

double n = Math.Sqrt(a);
Console.WriteLine (n);        */


Console.WriteLine("Введите координату точки X ");
int x1 =int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату точки Y");
int y1 =int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату точки X ");
int x2 =int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату точки Y");
int y2 =int.Parse(Console.ReadLine());



Double D = Math.Sqrt(Math.Pow(x1 - x2,2) + Math.Pow(y1 - y2,2));
Console.WriteLine(Math.Round(D,2));