// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         // Ввод числа с экрана
//         int Prompt(string message)
//         {
//             Console.Write(message); //Выводим приглашение ко вводу 
//             string? ReadInput = Console.ReadLine();
//             int result = int.Parse(ReadInput); //приводим к числу 
//             return result; //возвращаем результат
//         }
//         // метод для получения случайных значений массива
//         int[] GenerateArray(int Length, int minValue, int maxValue)
//         {
//             int[] array = new int[Length]; // обьявляем массив
//             Random random = new Random();
//             for (int i = 0; i < Length; i++)
//             {
//                 array[i] = random.Next(minValue, maxValue + 1); // заполняем случайными цифрами из диапазона SatrArr до EndArr
//             }
//             return array;
//         }
//         void PrintArray(int[] array)
//         {
//             Console.Write("[");
//             for (int i = 0; i < array.Length - 1; i++)
//             {
//                 Console.Write($"{array[i]}, "); //вывод значения массива
//             }
//             Console.Write($"{array[array.Length - 1]}"); //вывод значения
//             Console.WriteLine("]");
//         }
//         int length = Prompt("Длина массива: ");
//         int min = Prompt("Начальное значение, для диапазона случайного числа: ");
//         int max = Prompt("Конечное значение, для диапазона случайного числа:");
//         int[] array = GenerateArray(length, min, max); //заполнение массива случаными числами
//         PrintArray(array); // вывод массива
//     }
// }




int[] ArrRandom(int lenght = 0, int min = 0, int max = int.MaxValue)
{
    if (lenght == 0)
    {
        lenght = new Random().Next(2,12);
    }

    int[] arr = new int[lenght];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}
int[] ArrManually(int lenght)
{
    int[] arr = new int[lenght];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Entry($"Введите значение элемента {i} из {arr.Length-1}");
    }
    return arr;
}

void Print(int[] array)
{
    Console.Write($"[{string.Join(", ", array)}]");
}

int Entry(string msg)
{
    while (true)
    {
        try
        {
            Console.WriteLine(msg);
            return Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка ввода, введите цифры");
            continue;
        }
    }
}

int number = Entry("Нажмите\n1)Чтобы заполнить массив рандомно\n2)Чтобы назначить длину массива\n" +
    "3)Чтобы определить диапазон рандомных чисел\n4)Чтобы назначить длину массива и диапазон рандомных чисел\n" +
    "5)Чтобы назначить длину массива и заполнить массив");

switch (number)
{
    case 1:
        Print(ArrRandom());
        break;
    case 2:
        int length = Entry("Введите длину массива");
        Print(ArrRandom(length));
        break;
    case 3:
        int min = Entry("Введите минимальное значение");
        int max = Entry("Введите максимальное значение");
        Print(ArrRandom(0, min, max + 1));
        break;
    case 4:
        int length_ = Entry("Введите длину массива");
        int min_ = Entry("Введите минимальное значение");
        int max_ = Entry("Введите максимальное значение");
        Print(ArrRandom(length_, min_, max_ + 1));
        break;
    case 5:
        int length1 = Entry("Введите длину массива");
        Print(ArrManually(length1));
        break;
    default:
        Console.WriteLine("Ошибка!!! Введите числа от 1 до 5");
        break;
}