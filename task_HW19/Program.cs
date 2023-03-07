// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да




  // int Promt(string message)
  // {
  //     Console.Write(message);
  //     int result = Convert.ToInt32(Console.ReadLine());
  //     return result;
  // }

  //  int number = Promt ("Введите пятизначное число > ");
  //   if (number > 9999 && number < 100000)
  //   {
  //      Console.Write($"{number}");
  //       return number;
  //   }
  //   else
  //  {
  //   Console.WriteLine("Некорректный ввод");
  //     return number;
  //  }

  // int [] arr = new int [5];

  //      if (arr[0] == arr [4] && arr[1] == arr[3])
  //      {
  //        Console.WriteLine("Да");
  //      }
  //      else
  //      {
  //       Console.WriteLine("Нет");
  //      }
    


 
//     Console.WriteLine("Введите пятизначное число > ");
// string? number = Console.ReadLine();



// bool check = false;

// int[] createArray()
// {
//     int[]array = new int[number.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = number[i];
//     }
//     return array;
// }

// bool checkArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         if (array[i] == number?[number.Length - i - 1])
//         {
//             check = true;
//         }
//         else
//         {
//             check = false;
//             break;
//         }
//     }
//     return check;
// }

// checkArray(createArray());

// if (check)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }



 Console.WriteLine("Введите пятизначное число > ");
 string? namber = Console.ReadLine(); 
 int Namber = namber!.Length; 

 int[] arr = new int[Namber]; 
 bool polindrom = true; 

 for (int i = 0; i < Namber; i++) 
 { 
   arr[i] = namber[i]; 

 } 

 for(int i = 0; i < Namber; i++) 
 { 
   if(arr[i] != arr[Namber-i-1])
   { 
     Console.Write("Нет"); 
     polindrom = false;  
     break; 
   } 
 } 

 if (polindrom) 
 { 
   Console.Write(" Да"); 
 } 

