int[,] Create2dArray (int rows, int collums, int minValue, int maxValue)
{
    int[,] createdArray = new int[rows, collums];
    for (int i = 0; i < rows; i += 1)
    {
        for (int j = 0; j < collums; j += 1)
        {
            createdArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return createdArray;
}

void Print2dArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 1)
    {
        for (int j = 0; j < array.GetLength(1); j += 1)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Enter count of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter count of collums: ");
int userCollums = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min value: ");
int userMinValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max Value: ");
int userMaxValue = Convert.ToInt32(Console.ReadLine());

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] SortRowsDescending(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int[,] sortedArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            sortedArray[i, j] = array[i, j];
        }
        for (int j = 0; j < columns - 1; j++)
        {
            for (int k = j + 1; k < columns; k++)
            {
                if (sortedArray[i, j] < sortedArray[i, k])
                {
                    int temp = sortedArray[i, j];
                    sortedArray[i, j] = sortedArray[i, k];
                    sortedArray[i, k] = temp;
                }
            }
        }
    }
    return sortedArray;
}

int[,] firstArray = Create2dArray(userRows, userCollums, userMinValue, userMaxValue);
Print2dArray(firstArray);
int[,] modifiedFirstArray = SortRowsDescending(firstArray);
Print2dArray(modifiedFirstArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int FindMinSumFromArray (int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int minSum = int.MaxValue;
    int minSumRowIndex = -1;
    for (int i = 0; i < rows; i++)
    {
        int rowSum = 0;
        for (int j = 0; j < columns; j++)
        {
            rowSum += array[i, j];
        }
        if (rowSum < minSum)
        {
            minSum = rowSum;
            minSumRowIndex = i;
        }
    }
    return minSumRowIndex;
}

int[,] secondArray = Create2dArray(userRows, userCollums, userMinValue, userMaxValue);
Print2dArray(secondArray);
int summary = FindMinSumFromArray(secondArray);
Console.WriteLine($"The smallest sum of elements is found in the row: {summary}");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void ResultMatrix(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int columns1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int columns2 = matrix2.GetLength(1);
    if (columns1 != rows2)
    {
        Console.WriteLine("Error: The number of columns in the first matrix must be equal to the number of rows in the second matrix.");
    }
    int[,] resultMatrix = new int[rows1, columns2];
    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            int sum = 0;

            for (int k = 0; k < columns1; k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }

            resultMatrix[i, j] = sum;
        }
    }
    Console.WriteLine("Result Matrix:");
    Print2dArray(resultMatrix);
}

int[,] firstMatrix = Create2dArray(userRows, userCollums, userMinValue, userMaxValue);
int[,] secondMatrix = Create2dArray(userRows, userCollums, userMinValue, userMaxValue);
Print2dArray(firstMatrix);
Print2dArray(secondMatrix);
ResultMatrix(firstMatrix, secondMatrix);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void Print3DArray(int[,,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int depth = array.GetLength(2);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] Create3DArray(int rows, int columns, int depth)
{
    int[,,] createdArray = new int[rows, columns, depth];
    List<int> usedNumbers = new List<int>();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                int randomNumber;
                do
                {
                    randomNumber = new Random().Next(10, 100);
                } while (usedNumbers.Contains(randomNumber));

                createdArray[i, j, k] = randomNumber;
                usedNumbers.Add(randomNumber);
            }
        }
    }
    return createdArray;
}

int rows = 2;
int columns = 2;
int depth = 2;

int[,,] array = Create3DArray(rows, columns, depth);
Print3DArray(array);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillSpiralArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int totalElements = rows * columns;
    int value = 1;
    int row = 0;
    int column = 0;
    int direction = 0;
    int[] dr = { 0, 1, 0, -1 };
    int[] dc = { 1, 0, -1, 0 };
    for (int i = 0; i < totalElements; i++)
    {
        array[row, column] = value;
        value += 1;
        int newRow = row + dr[direction];
        int newColumn = column + dc[direction];
        if (newRow < 0 || newRow >= rows || newColumn < 0 || newColumn >= columns || array[newRow, newColumn] != 0)
        {
            direction = (direction + 1) % 4;
            newRow = row + dr[direction];
            newColumn = column + dc[direction];
        }
        row = newRow;
        column = newColumn;
    }
}

int[,] lastArray = new int[4, 4];
FillSpiralArray(lastArray);
Print2dArray(lastArray);