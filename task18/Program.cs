// Задача №18. Работа в группах
// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
//double number = 5.321321321321;
//double result1 = Math.Round(number,2);// Округление
//System.Console.WriteLine(result1);
//double master = Math.Pow(number,2); // Возведение в квадрат
//double number1 = Math.Sqrt(25); // квадратный корень
//System.Console.WriteLine(number1);
//double result = Math.Round(Math.Sqrt(Math.Pow(number, 2)), 2);
//System.Console.WriteLine(result);

// Console.Write("Введите четверть: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// switch (number1)
// {
//     case  1:
//         Console.Write("x>0 y >0");
//         break;
//     case  2:
//         Console.Write("x < 0  y > 0");
//         break;
//     case  3:
//         Console.Write("x < 0 y < 0");
//         break;    
//     case  4:
//         Console.Write("x > 0 y < 0");
//         break;    
// }

int Promt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

bool Checked(int quater)
{
    if(quater >= 1 && quater <= 4)
    {
        return true;
    }
    else
    {
        return false;
    }
}
string[] quaters ={"x > 0; y > 0", "x < 0; y > 0", "x < 0; y < 0", "x > 0; y < 0"};

int quater = Promt("Введите четверть: ");

if(Checked(quater))
{
    Console.Write(quaters[quater - 1]);
}
else
{
    Console.Write("Неправильный номер четверти");
}
