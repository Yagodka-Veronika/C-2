﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AccermanFunction(int m,int n)
{
    if(m > 0&&n > 0)
    {
      return AccermanFunction(m-1, AccermanFunction(m, n-1));  
    }
    else if( m > 0 && n == 0)
    {
    return AccermanFunction(m-1,1);
    } 
    else 
    {
      return n+1;  
    }
    
}
    
Console.Write("m = ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("n = "); 
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write($"A(m,n) = {AccermanFunction(numberM,numberN)}");
