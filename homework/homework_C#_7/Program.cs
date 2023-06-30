void Print2dArrayInt(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i += 1)
    {
        for (int j = 0; j < array2d.GetLength(1); j += 1)
        {
            Console.Write(array2d[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Print2dArrayDouble(double[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i += 1)
    {
        for (int j = 0; j < array2d.GetLength(1); j += 1)
        {
            Console.Write(array2d[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateRandomDoubleArray()
{
    int rowsOfArray = 3;
    int collumsOfArray = 4;
    Console.WriteLine("Enter min value for array: ");
    double userMinValue = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter max value for array: ");
    double userMaxValue = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine();

    double[,] new2dArray = new double[rowsOfArray, collumsOfArray];
    for (int i = 0; i < new2dArray.GetLength(0); i += 1)
    {
        for (int j = 0; j < new2dArray.GetLength(1); j += 1)
        {
            new2dArray[i, j] = Math.Round(new Random().NextDouble() *
            (userMaxValue - userMinValue) + userMinValue, 1); 
        }
    }
    return new2dArray;
}

Print2dArrayDouble(CreateRandomDoubleArray());


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Enter count of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter count of collums: ");
int userCollums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min value for array: ");
int userMinValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value for array: ");
int userMaxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] CreateRandomIntArray()
{
    int[,] new2dArray = new int[userRows, userCollums];
    for (int i = 0; i < new2dArray.GetLength(0); i += 1)
    {
        for (int j = 0; j < new2dArray.GetLength(1); j += 1)
        {
            new2dArray[i, j] = new Random().Next(userMinValue, userMaxValue + 1); 
        }
    }
    return new2dArray;
}

void FindNumberByCoord(int[,] array2d)
{
    Console.WriteLine("Enter the coordinate to find the number: ");
    int userCoord = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int rowOfArray = userCoord / 10;
    int collumOfArray = userCoord % 10;
    if ((rowOfArray >= 0 && rowOfArray <= userRows) && 
        (collumOfArray >= 0 && collumOfArray <= userCollums))
        for (int i = 0; i < array2d.GetLength(0); i += 1)
        {
            for (int j = 0; j < array2d.GetLength(1); j += 1)
            {
                if (rowOfArray == i && collumOfArray == j)
                {
                    Console.WriteLine($"The number is according to your coordinates: {array2d[i, j]}");
                }
            }
        }
    else
        {
        Console.WriteLine($"{userCoord} - there is no such point in the array");
        }
}

int[,] test = CreateRandomIntArray();
Print2dArrayInt(test);
FindNumberByCoord(test);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FindAVGByCollum(int[,] array2d)
{
    Console.WriteLine("Enter the column in which you want to find AVG: ");
    int findCollum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int sum = 0;
    for (int i = 0; i < array2d.GetLength(0); i += 1)
    {
        sum += array2d[i, findCollum];
    }
    double avg = Math.Round((double)sum / array2d.GetLength(0), 1);
    Console.WriteLine($"The arithmetic mean of the {findCollum} column is {avg}");
}

int[,] newTest = CreateRandomIntArray();
Print2dArrayInt(newTest);
FindAVGByCollum(newTest);