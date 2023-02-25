// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int EnterData(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int ShowSumCount(int M, int N)
{
    if (M == N) return N;
    
    if (M < 1 || N < 1)
    {
        Console.Write("Enter count more than zero");
        return 0; // не понял только как сделать, чтобы не выводил ноль при срабатывании этого условия
    }
    else
    {
        if (M < N) return M + ShowSumCount(M + 1, N);
 
        else return M + ShowSumCount(M - 1, N);
    }
}
int M = EnterData("Enter M");
int N = EnterData("Enter N");

Console.WriteLine(ShowSumCount(M, N));