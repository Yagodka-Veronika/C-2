// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int IntegersSum(int M, int N)
{
    if(M == N)
    {
        return M;
    }

    return N + IntegersSum(M,N-1);  
}
Console.Write("M = ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("N = ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write($"{IntegersSum(numberM,numberN)}");
