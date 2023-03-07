// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Pr(int number)
{
    int pr = 1;
    for(int i = 1; i <= number; i++)
    {
        pr = pr*i; // == pr*=i
    }
    return pr;
}

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Произведение чисел от 1 до N = {Pr(N)}");