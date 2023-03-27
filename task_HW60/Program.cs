// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] FillArray3DWithRandom( int side, int row, int column) 
{ 
    int[,,] Array3D = new int[side, row, column]; 
    Random rnd = new Random();
    for(int i = 0; i < side; i++) 
    { 
        for(int j = 0; j < row; j++) 
        { 
            for(int k = 0; k < column; k++) 
            { 
                Array3D[i,j,k] = rnd.Next(10, 100);
            } 
        } 
    } 
    return Array3D; 
    } 
void PrintArray3D(int[,,] Array3D) 
{ 
     for (int i = 0; i < Array3D.GetLength(0); i++) 
     { 
        for(int j = 0; j < Array3D.GetLength(1); j++) 
        { 
             for(int k = 0; k < Array3D.GetLength(2); k++) 
             { 
                 Console.Write($"{Array3D[i,j,k]}({i},{j},{k}) ");
             } 
             Console.WriteLine();
        } 
     } 
} 
Console.Write("X: "); 
int X = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Y: "); 
int Y = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Z: "); 
int Z = Convert.ToInt32(Console.ReadLine()); 
int[,,] Array3D = FillArray3DWithRandom(X, Y, Z); 
PrintArray3D(Array3D);

