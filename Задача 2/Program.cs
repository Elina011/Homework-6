﻿// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}

double b1 = EnterData("Введите значение b1 ");
double k1 = EnterData("Введите значение k1 ");
double b2 = EnterData("Введите значение b1 ");
double k2 = EnterData("Введите значение k2 ");

for (double i = -100; i < 101; i+=0.25)
{
    double y1 = k1 * i + b1;
    double y2 = k2 * i + b2;
    if (y1 == y2)
    {
        Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({i}; {y1});");
    }
}