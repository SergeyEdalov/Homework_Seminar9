// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int EnterData(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int ShowCounts(int N)
{
    if (N == 0) return N;
    else if (N <= 0)
    {
        Console.Write("Enter count more than zero");
        return N;
    }
    Console.Write(N + " ");
    return ShowCounts(N - 1);
}

int N = EnterData("Enter N");

ShowCounts(N);