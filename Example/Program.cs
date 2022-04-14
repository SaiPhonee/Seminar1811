// 41. Выяснить являются ли три числа сторонами треугольника 
// Console.WriteLine("Введите первую сторону треугольника");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите вторую сторону треугольника");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третью сторону треугольника");
// int c = Convert.ToInt32(Console.ReadLine());
// if (a + b <= c || b + c <= a || a + c <= b)
// {
//     Console.WriteLine("Являются");
// }
// else
// {
//     Console.WriteLine("Не являются");
// }

// bool IsTriangle(int a, int b, int c)
// {
//     if (a + b > c && b + c > a && a + c > b)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }
// Console.WriteLine(IsTriangle(1111, 34, 14));


// 42. Определить сколько чисел больше 0 введено с клавиатуры


// 43. Написать программу преобразования десятичного числа в двоичное


//100010

// int number = 334;
// int d10 = 1;
// int result = 0;
// while (number != 0)
// {
//     result = result + number % 2 * d10;
//     number = number / 2;
//     d10 = d10 * 10;
// }
// Console.WriteLine(result);

// int Translate10to2(int number)
// {
//     int d10 = 1;
//     int result = 0;
//     while (number > 0)
//     {
//         result = result + number % 2 * d10;
//         number = number / 2;
//         d10 = d10 * 10;

//     }
//     return result;
// }

// Console.WriteLine(Translate10to2(46));

// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2 заданы

// int a1 = 1;
// int k1 = 2;
// int a2 = 5;
// int k2 = 4;
// int x = (a2-a1)/(k1-k2);
// int y = (a2*k1-a1*k2)/(k1 - k2);
// Console.WriteLine(x);
// Console.WriteLine(y);

// 45. Показать числа Фибоначчи

// int a = 0;
// int b = 1;
// int c = 0;
// int n = 10;
// for (int i = 0; i <= n; i++)
// {
//     c = b + a;
//     a = b;
//     b = c;
//     //Console.WriteLine(a);
//     //Console.WriteLine(b);
//     Console.WriteLine(c);
// }


// 46. Написать программу масштабирования фигуры

// 47. Написать программу копирования массива
// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 10);
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine(" ");
// int[] array2 = new int[10];
// for (int i = 0; i < array2.Length; i++)
// {
//     array2[i] = array[i];
//     Console.Write(array2 + " ");
// }


// int min = 30001;
// int a = Convert.ToInt32(Console.ReadLine());
// while (a != 0)
// {
//     if ((a % 4 == 0) && (a % 8 != 0) && (a < min))
//     {
//         min = a;
//     }
//     a = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine(min);
int[] array = [5,10,3,5,8,6,1,4,9,11];
// array = [5,10,3,5,8,6,1,4,9,11];
int count = 0;
int temp = 0;
for(int i =0; i<array.Length; i++)
{
    if (array[i]<array[0])
    {
        count++;
        temp = array[i];
        array[i] = array[0];
        array[0] = temp;

    }
}
Console.WriteLine(count);