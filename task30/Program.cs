// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

//8 = = 8;
// int[] arr = new int[8];
// Random rand = new Random();
// for    (int i=0; i<8; i++) 
// {
//     arr[i] = rand.Next(0,2);
// }
// Console.WriteLine(string.Join(", ", arr));


// void ArrayEightValue ()
// {
//     int [] tempArray = new int [8];
//     for (int i = 0; i < 8; i++)
//     {
//         tempArray[i] = new Random().Next(0, 2);
//         Console.Write(tempArray[i]);
//     }
    
// }



// ArrayEightValue ();



System.Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(0,2);
}
Console.WriteLine(string.Join(", ", arr));
