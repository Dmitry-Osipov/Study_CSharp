// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел
// больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void CountOfPos()
{
    Console.Write("Enter the numbers, separated by a space: ");
    string input = Console.ReadLine();
    string[] numbers_stirng = input.Split();
    int[] numbers = new int[numbers_stirng.Length];
    for (int i = 0; i < numbers_stirng.Length; i += 1)
    {
        numbers[i] = Convert.ToInt32(numbers_stirng[i]);
    }

    int count_of_pos = 0;
    for (int j = 0; j < numbers.Length; j += 1)
    {
        if (numbers[j] > 0)
        {
            count_of_pos += 1;
        }
    }
    Console.WriteLine($"The number of numbers is greater than 0: {count_of_pos}");
}

CountOfPos();

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y = k1 * x + b1 - позволяет найти координату пересечения для y
// x = (b2 - b1) / (k1 - k2) - позволяет найти координату пересечения для x

void FindCoord(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Point of intersection: ({x}; {y})");
}

Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

FindCoord(b1, k1, b2, k2);