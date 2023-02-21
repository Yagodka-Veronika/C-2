// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

 Console.Write("Введите трехзначное число: ");
 int N = Convert.ToInt32(Console.ReadLine());
 int SecondNumber = 0;
 if(N > 99 && N < 1000)
 {
     SecondNumber = N/10 %10;
     Console.Write(SecondNumber);
 }
 else
 {
     Console.Write("Некорректный ввод");
 }

//Эталонное решение
// int Promt(string message)
// {
//     Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// int number = Promt ("Введите трехзначное число > ");
// if (number < 100 || number >= 1000)
// {
//     Console.WriteLine("Некорректный ввод");
//     return ;
// }

// Console.WriteLine($" Введите число `{number}`");
// int secondRank = number / 10 % 10;
// Console.WriteLine($" Вторая цифра `{secondRank}`");
