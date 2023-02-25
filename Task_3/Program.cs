// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int EnterData(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int FunctionAkkerman(int n, int m)
{
    if (n == 0) return m + 1;
    else if ((n != 0 && m == 0)) return FunctionAkkerman(n - 1, 1);
    else return FunctionAkkerman(n - 1, FunctionAkkerman(n, m - 1));
}
int n = EnterData("Enter argument function Akkerman n");
int m = EnterData("Enter argument function Akkerman m");

Console.WriteLine(FunctionAkkerman(n, m));