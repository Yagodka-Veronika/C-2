﻿// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

double[] side = new double[3];
for (int i = 0; i < side.Length; i++)
{
    Console.WriteLine($"Введит длину стороны {i+1}");
    side[i] = Convert.ToDouble(Console.ReadLine());
}
 if(side[0] < side[1] + side[2] && side[1] < side[0] + side[2] && side[2] < side[0] + side[1])
 {
    Console.Write($"Да");
 }
 else
 {
    Console.Write($"Нет");
 }



//  Console.WriteLine("Введите первую сторону: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите вторую сторону: ");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третью сторону: ");
// int C = Convert.ToInt32(Console.ReadLine());

// if(A + B > C && B + C > A && A + C > B)
// {
// Console.WriteLine("Существует");
// }
// else
// {
// Console.WriteLine("Не существует");
// }