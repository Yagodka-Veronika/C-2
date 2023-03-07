// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


// int Num(int n)
// {
//     string ns = n.ToString();
//     return ns.Length;
// }

// System.Console.Write("Введите число: ");
// int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// int result = Num(a);
// System.Console.WriteLine(result);



int Counter(int number)
{
int count = 0;
if(number == 0)
{
count = 1;
}
while(number > 0)
{
number/=10; // == number = number/10
count++;
}
return count;
}

System.Console.Write("Введите число: ");
int A = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.Write($"Количество цифр в числе = {Counter(A)}");