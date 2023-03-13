// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
﻿
// int Promt(string message)
  // {
  //     Console.Write(message);
  //     int result = Convert.ToInt32(Console.ReadLine());
  //     return result;
  // }
// int Prompt(string message)
//     {
//     Console.Write(message); //Выводим приглашение ко вводу
//     string? readInput = System.Console.ReadLine(); // Вводим значение 
//     int result = int.Parse(readInput); //приводим к числу
//     return result; //возвращаем результат
//     }
// int Power (int powerBase, int exponent)
//     {
//     int power = 1;
//     for (int i = 0; i < exponent; i++)
//     {
//         power *= powerBase;
//     }
//     return power;
//     }
// bool ValidateExponent (int exponent)
//     {
//     if (exponent < 0)
//     {
//     System.Console.WriteLine("Показатель не должен быть меньше нуля");
//     return false;
//     }
//     return true;
//     }
// int powerBase = Prompt("Введите основание: ");
// int exponent = Prompt("Введите показатель: ");
// if (ValidateExponent (exponent))
// {
//    System.Console.WriteLine($"число {powerBase} в степени {exponent} равно {Power (powerBase, exponent)}"); 
// }





int Rank(int[] arr)
{
    int result = 1;
    for (int i = 0; i < arr[1]; i++)
    {
        result = result * arr[0];
    }
    return result;
}

int Entry(string msg)
{
    while (true)
    {
        try
        {
            Console.Write(msg);
            return Convert.ToInt32(Console.ReadLine()); ;
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка ввода, введите цифры");
            continue;
        }
    }
}

string[] str = { "A", "B" };
int[] arr = new int[str.Length];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Entry($"Введите число {str[i]} ");
}

if (arr[1] < 0)
{
    Console.Write($"Ошибка!!! число B неможет быть меньше нуля");
}
else
{
    Console.WriteLine(Rank(arr));
}