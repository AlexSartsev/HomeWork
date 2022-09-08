// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int m, int n)
{          
    if (m == n) return m;                          
    else if (m < n) return n + SumNumbers(m, n - 1);         
    else return n + SumNumbers(m, n + 1);               
}

Console.Write("M = ");
int numberOne = int.Parse(Console.ReadLine());

Console.Write("N = ");
int numberTwo = int.Parse(Console.ReadLine());

Console.WriteLine($"Result, S = {SumNumbers(numberOne, numberTwo)}");