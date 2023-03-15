// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double[] ArrayWithRandomNumbers(int lenght)
{
    double[] arr = new double[lenght];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() + rnd.Next(0,100),2);
    }
    return arr;
}
double DiffMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return Math.Round(max - min, 2);
}

Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] arr = ArrayWithRandomNumbers(length);
Console.Write($"[{string.Join("; ", arr)}]");
Console.WriteLine($" -> {DiffMaxMin(arr)}");






 


