// Задача 1: Напишите программу, которая принимает на вход три числа
//  и проверяет, может ли существовать треугольник с сторонами такой длины.

int ReadInt(string msg)
{
    System.Console.Write($"{msg} > ");
    return int.Parse(Console.ReadLine());
}


int sA = ReadInt("Введите сторону а ");
int sB = ReadInt("Введите сторону b ");
int sC = ReadInt("Введите сторону c ");

if (sA < sB + sC && sB < sA +sC && sC < sA + sB)
{
    System.Console.WriteLine("Может существовать");
}
else
{
    System.Console.WriteLine("Не может существовать");
}