// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет





int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}



void FindNumber(int[,] matrix, int indexI, int indexJ)
{
    if (indexI>=matrix.GetLength(0) || indexJ>=matrix.GetLength(1))
        {
            Console.Write($"Такого числа в массиве нет!"); 
        }
    for (int i=0; i < matrix.GetLength(0); i++)
    {
        for(int j=0; j < matrix.GetLength(1); j++)
        {
            if (i==indexI-1 && j==indexJ-1)
                {
                    Console.Write($"-> " + matrix[i,j]);
                }
        }
    }  
}

Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);
Console.Write("Выберите строку ");
int indexI = Convert.ToInt32(Console.ReadLine());
Console.Write("Выберите столбец ");
int indexJ = Convert.ToInt32(Console.ReadLine());
FindNumber(matrix, indexI, indexJ);












