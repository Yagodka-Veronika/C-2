// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2



int[] FillArrayWithRandomNumbers(int length)
{
    int[] arr = new int [length];
    Random rnd = new Random();
    for(int i =0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumbers(length);
int countEvenNumber = 0;

Console.Write($"[ {string.Join(", ", array)} ]");

for(int i = 0; i < array.Length; i++)
{
    if(array[i]%2==0)
    {
       countEvenNumber++; 
    }
        
}
Console.WriteLine($" -> {countEvenNumber}");



