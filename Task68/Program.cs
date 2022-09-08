// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int FunctionAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return FunctionAkkerman(m - 1, 1);
    else if (m > 0 && n > 0) return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
    return FunctionAkkerman(m, n);
}

Console.Write("Введите первое неотрицательное число: ");
int numberOne = int.Parse(Console.ReadLine());

Console.Write("Введите второе неотрицательное число: ");
int numberTwo = int.Parse(Console.ReadLine());

Console.WriteLine($"Result, S = {FunctionAkkerman(numberOne, numberTwo)}");