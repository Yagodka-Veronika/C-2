// Задача №22. Работа в группах
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// int Pront(string message)
// {
//   System.Console.Write(message);
//   int result = Convert.ToInt32(System.Console.ReadLine());
//   return result;
// }

// void PowSistem(double number)
// {
//   for(int i = 1; i < number; i++)
//   {
//     double result = Math.Round(Math.Pow(i,2)); //возведение в степень и округление 
//     Console.WriteLine($"{result}, ");
//   }
    
// }

// double qwadrat = Pront("Введите число ->");
// PowSistem(qwadrat);

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)// i = i + 2
{
    System.Console.Write($"{Math.Pow(i, 2)} ");
}
