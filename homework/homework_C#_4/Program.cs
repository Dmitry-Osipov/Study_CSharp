// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A
// в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponentiate(int number, int degree)
{
    int result = 1;
    for (int count = 0; count < degree; count += 1)
    {
        result *= number;
    }
    return result;
}
Console.Write("Введите число, которое нужно возвести в степень: ");
int user_number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int user_degree = Convert.ToInt32(Console.ReadLine());
if (user_degree >= 0)
{
    Console.WriteLine($"Число {user_number} в степени {user_degree} = {Exponentiate(user_number, user_degree)}");
}
else
{
    Console.WriteLine("Введённая степень не является натуральным числом");
}

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int FindSumm(int number)
{
    int result = 0;
    int count = number;
    while (count != 0)
    {
        int last_digit = count % 10;
        result += last_digit;
        count /= 10;
    }
    return result;
}
Console.Write("Введите число: ");
int new_user_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр Вашего числа: {FindSumm(new_user_number)}");

// Задача 29: Напишите программу, которая задаёт массив из произвольного числа элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateRandomArray(int size_array)
{
    int[] RandomArray = new int[size_array];
    for (int i = 0; i < size_array; i += 1)
    {
        RandomArray[i] = new Random().Next(0, 101);
    }
    return RandomArray;
}

void PrintArray(int[] PrintedArray)
{
    Console.WriteLine("Ваш массив: ");
    for (int i = 0; i < PrintedArray.Length; i += 1)
    {
        Console.Write($"{PrintedArray[i]} ");
    }
}
Console.Write("Введите длину массива: ");
int user_size = Convert.ToInt32(Console.ReadLine());
PrintArray(CreateRandomArray(user_size));
