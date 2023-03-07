// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


int[] FillArrayWithRandomNumbers(int length)
{
    int[] arr = new int [length];
    Random rnd = new Random();
    for(int i =0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}

System.Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumbers(length);

System.Console.WriteLine($"[ {string.Join(", ", array)} ]");

System.Console.WriteLine("Введите поисковое число: ");
int gis = Convert.ToInt32(Console.ReadLine());
bool number = false;

for (int i = 0; i < array.Length; i++)
{
  if(gis == array[i])
  {
    System.Console.WriteLine("Число имеется");
    number = false;
    break;
  }
  else
  {
    number = true;
  }
}

if (number)
{
  System.Console.WriteLine("Число не имеется");
}




// int[] FillArrayWithRandomNumbers(int length)
// {
//     int[] arr = new int [length];
//     Random rnd = new Random();
//     for(int i =0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(-9, 10);
//     }
//     return arr;
// }

// System.Console.WriteLine("Введите длину массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArrayWithRandomNumbers(length);

// System.Console.WriteLine($"[ {string.Join(", ", array)} ]");

// System.Console.WriteLine("Введите поисковое число: ");
// int gis = Convert.ToInt32(Console.ReadLine());
// bool number = false;

// for (int i = 0; i < array.Length; i++)
// {
//   if(gis == array[i])
//   {
//     System.Console.WriteLine("Число имеется");
//     number = false;
//     break;
//   }
//   else
//   {
//     number = true;
//   }
// }

// if (number)
// {
//   System.Console.WriteLine("Число не имеется");
// }



// string ArrSearch(int search, int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (search == array[i])
//             return $"данное число под индексом {i}";
//     }
//     return "Такого числа нету";
// }




// int Entry(string msg)
// {
//     Console.WriteLine(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[] ArrManually(int lenght)
// {
//     int[] arr = new int[lenght];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = Entry($"Введите целочисленное значение в элемент {i}");
//     }
//     return arr;
// }

// string ArrSearch(int search, int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (search == array[i])
//             return $"данное число под индексом {i}";
//     }
//     return "Такого числа нету";
// }
// int lenght = Entry($"Введите длину массива");
// int[] array = ArrManually(lenght);
// Console.Write($"[{string.Join(", ", array)}]");
// int search = Entry($"Введите число которую ищите");
// Console.WriteLine(ArrSearch(search, array));


// Алексей
// int[] FillArrayWithRandomNumbers(int length)
// {
// int[] arr = new int[length];
// Random rnd = new Random();
// for (int i = 0; i < arr.Length; i++)
// {
// arr[i] = rnd.Next(-9, 10);
// }
// return arr;
// }

// bool isOk(int[] array, int number)
// {
// //bool trust = false;
// for (int i = 0; i < array.Length; i++)
// {
// if (number == array[i])
// {
// //bool trust = true;
// return true;
// }
// }
// return false;
// }

// System.Console.WriteLine("Введите длину массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArrayWithRandomNumbers(length);
// System.Console.WriteLine($"[{string.Join(", ", array)}]");
// int number = Convert.ToInt32(Console.ReadLine());

// if (isOk(array, number))
// {
// System.Console.WriteLine("Элемент найден");
// }
// else
// {
// System.Console.WriteLine("Элемент не найден");
// }






// int[] FillArrayWithRandomNumbers(int length)
// {
//     int[] arr = new int [length];
//     Random rnd = new Random();
//     for(int i =0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(-9, 10);
//     }
//     return arr;
// }

// System.Console.WriteLine("Введите длину массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArrayWithRandomNumbers(length);

// System.Console.WriteLine($"[ {string.Join(", ", array)} ]");

// System.Console.WriteLine("Введите поисковое число: ");
// int gis = Convert.ToInt32(Console.ReadLine());


// bool Gis(int [] arr)
// {
// bool number = false;
// for (int i = 0; i < arr.Length; i++)
// {
//   if(gis == arr[i])
//   {
//     number = false;
//     break;
//   }
//   else
//   {
//     number = true;
//   }
// }
// return number;
// }

// if (Gis(array))
// {
//   System.Console.WriteLine("Число не имеется");
// }
// else
// {
//  System.Console.WriteLine("Число имеется");
// }