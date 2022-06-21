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