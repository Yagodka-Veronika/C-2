// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
﻿//Эталонное решение
int Promt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

bool IsWeekend(int weekDay)
{
 if (weekDay > 5)
 {
  return true;
 }
  return false;
}
bool ValidateWeekday(int number)
{
if (number > 0 && number <= 7)
 {
 return true;
 }
Console.WriteLine("Это не день недели!"); 
return false;
}
int weekDay = Promt ("Введите день недели >");
if (ValidateWeekday(weekDay))
{
if (IsWeekend(weekDay))
{
Console.WriteLine("Наконец-то выходной");
}
else
{
Console.WriteLine("Придется поработать");
}
}