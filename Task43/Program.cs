// Задача 43: Напишите программу, 
// которая найдёт точку пересечения 
// двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение b1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение k1: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение b2: ");
int number3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение k2: ");
int number4 = Convert.ToInt32(Console.ReadLine());

void IntersectionsOfPoints(double b1, double k1, double b2, double k2)
{
    double x = default;
    double y = default;

    x = (b2 - b1) / (k1 - k2);
    y = k1 * (b2 - b1) / (k1 - k2) + b1;
    
    Console.WriteLine($"{x}, {y}");
}

IntersectionsOfPoints(number1, number2, number3, number4);