﻿// вычисление четверти на сетке координат
// Console.Clear();
// Console.Write("Введите координату X: ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y: ");
// double y = Convert.ToDouble(Console.ReadLine());
// while (x == 0 || y == 0)
// {
//     Console.WriteLine("Вы ошиблись! Введите координаты заново!");
//     Console.Write("Введите координату X: ");
//     x = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите координату Y: ");
//     y = Convert.ToDouble(Console.ReadLine());
// }
// if (x > 0 && y > 0)
//     Console.WriteLine("I");
// else if (x < 0 && y > 0)
//     Console.WriteLine("II");
// else if (x < 0 && y < 0)
//     Console.WriteLine("III");
// else
//     Console.WriteLine("IV");


// Console.Clear();
// Console.Write("Введите четверть N: ");
// int  N = Convert.ToInt32(Console.ReadLine());
// while (N <0 || N > 4)
// {
//     Console.WriteLine("Вы ошиблись! \nВведите номер четверти заново!");
//     Console.Write("Введите четверть: ");
//     N = Convert.ToInt32(Console.ReadLine());

// }
// if (N==1)
//     Console.WriteLine("x>0,y>0");
// else if (N==2)
//     Console.WriteLine("x>0,y<0");
// else if (N==3)
//     Console.WriteLine("x<0,y<0");
// else
//     Console.WriteLine("x>0,y<0");

// Console.Clear();
// Console.Write("Введите номер четверти: ");
// int n = Convert.ToInt32(Console.ReadLine());
// while (n < 1 || n > 4)
// {
//     Console.WriteLine("Вы ошиблись!\nВведите число: ");
//     n = Convert.ToInt32(Console.ReadLine());
// }
// if (n == 1)
//     Console.WriteLine("x(0, +∞) and y(0, +∞)");
// else if (n == 2)
//     Console.WriteLine("x -∞, 0 and y 0, +∞ ");
// else if (n == 3)
//     Console.WriteLine("x -∞, 0 and y -∞, 0 ");
// else
//     Console.WriteLine("x(0, +∞) and y(-∞, 0)");

// Task 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D 
// Console.Clear();
// Console.Write("Введите X1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите Y1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите X2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите Y2: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// double l = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2)), 2);
// Console.WriteLine(l);


// принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
    Console.Write($"{Math.Pow(i, 3)} ");

    // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D 
Console.Clear();
Console.Write("Введите X1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите X2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
double l = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2)+ Math.Pow(z1 - z2, 2)), 2);
Console.WriteLine(l);

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
    Console.Write($"{Math.Pow(i, 3)} ");