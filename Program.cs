// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа 
//  в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// int lastNum = 1;

// string PrintNumbers(int num1, int num2)
// {
//     if (N <= 0)
//     {
//         return "число не подходит";
//     }
//     if (num1 == num2)
//     {
//         return num2.ToString();
//     }
//     return (num1 + " " + PrintNumbers(num1 -1, num2));
// }

// Console.WriteLine(PrintNumbers(N, lastNum));



// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Console.WriteLine("Введите число");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());

// int SumOfNumbers(int num1, int num2)
// {
//     if ((N < 0)||(M < 0))
//     {
//         Console.WriteLine("Числа не подходят");
//         return 0;
//     }
//     if (N < M)
//     {
//         Console.WriteLine("Поменяйте числа местами");
//         return 0;
//     }
//     if (num1 == num2)
//     {
//         return num2;
//     }
//     return (num1 + SumOfNumbers(num1+1, num2));
// }

// Console.WriteLine(SumOfNumbers(M,N));



// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите число");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());


int Akkerman(int num1, int num2)
{
    if ((N < 0)||(M < 0))
    {
        Console.WriteLine("Числа не подходят");
        return 0;
    }
    if (num1 == 0)
    {
        return num2 + 1;
    }
    if (num1 > 0 && num2 == 0)
    {
        return Akkerman( num1 - 1, 1);
    }
    
    return Akkerman( num1 -1, Akkerman(num1, num2 - 1));
    
}

Console.WriteLine(Akkerman(M,N));