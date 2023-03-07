// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


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



// System.Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// Random rnd = new Random();
// for(int i = 0; i < arr.Length; i++)
// {
// arr[i] = rnd.Next(100,1000);
// }
// Console.WriteLine(string.Join(", ", arr));


// int[] FillArrayWithRandomNumbers(int length)
// {
//     int[] arr = new int [length];
//     Random rnd = new Random();
//     for(int i =0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(100, 1000);
//     }
//     return arr;
// }

// System.Console.WriteLine("Введите длину массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArrayWithRandomNumbers(length);
// int evenNumber = 0;
// int sumNegative = 0;
// System.Console.WriteLine($"[ {string.Join(", ", array)} ]");

// for(int i = 0; i < array.Length; i++)
// {
//     int evenNumber = 0;
//     evenNumber %2 == 0;
// }
// Console.WriteLine($" = {evenNumber}");
