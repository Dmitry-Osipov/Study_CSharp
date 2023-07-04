// Задача 1: Задайте двумерный массив. Напишите программу,
// которая поменяет местами две любые строки массива

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

void Show2dIntArray (int[,] array)
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

int[,] ChangeRows (int[,] array, int row1, int row2)
{
    if (row1 <= array.GetLength(0) &&
        row1 >= 0 &&
        row1 != row2 &&
        row2 >= 0 &&
        row2 <= array.GetLength(0))
    {
        for (int j = 0; j < array.GetLength(1); j += 1)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }
    else
    {
        Console.WriteLine("Error! Impossible value!");
    }
    return array;
}

Console.Write("Input count of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of collums: ");
int userCollums = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int userMinValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int userMaxValue = Convert.ToInt32(Console.ReadLine());
Console.Write($"Input number of the first row to remove for 0 to {userRows - 1}: ");
int userFirstRow = Convert.ToInt32(Console.ReadLine());
Console.Write($"Input number of the second row to remove for 0 to {userRows - 1}: ");
int userSecondRow = Convert.ToInt32(Console.ReadLine());

int[,] firstArray = Create2dArray(userRows, userCollums, userMinValue, userMaxValue);
Show2dIntArray(firstArray);
int[,] changedArray = ChangeRows(firstArray, userFirstRow, userSecondRow);
Show2dIntArray(changedArray);

//Задача 2.
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] ChangeRowAndCollum (int[,] array, int rows, int colums)
{
    int[,] temp = new int[rows, colums];
    if (rows == colums)
    {
        for (int i = 0; i < array.GetLength(0); i += 1)
        {
            for (int j = 0; j < array.GetLength(1); j += 1)
            {
                temp[j, i] = array[i, j];
            }
        }
    }
    else Console.WriteLine("Error: rows != colums");
    return temp;
}

Console.Write("Input count of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of colums: ");
int userColums = Convert.ToInt32(Console.ReadLine());
int[,] secondArray = Create2dArray(userRows, userColums, 1, 9);
Show2dIntArray(secondArray);
int[,] changedArrayColum = ChangeRowAndCollum(secondArray, userRows, userColums);
Show2dIntArray(changedArrayColum);

//Задача 3.
// Задайте двумерный массив из целых чисел. Напишите программу, которая обнулит строку и столбец, 
// на пересечении которых расположен первый наименьший элемент массива.

int [,] Created2dArray (int rows, int columns)
{
    int [,] createdArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            createdArray[i,j] = new Random().Next(-9, 10);
    return createdArray;
}

void ShowArray (int [,] printedArray)
{
    for (int i = 0; i < printedArray.GetLength(0); i++)
    {    
        for (int j = 0; j < printedArray.GetLength(1); j++)
        {
            Console.Write(printedArray[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();    
}

int [] FindFirstMin (int [,] arrayToAnalyse)
{
    int min = arrayToAnalyse[0,0];
    int [] coord = new int[2];
    for (int i = 0; i < arrayToAnalyse.GetLength(0); i++)
        {    
            for (int j = 0; j < arrayToAnalyse.GetLength(1); j++)
                if (min > arrayToAnalyse[i,j])
                {
                    min = arrayToAnalyse[i,j];
                    coord[0] = i;
                    coord[1] = j;
                }
        }
    return coord;
}

int [,] arrayToDemonstrate (int [,] arrayToProcess, int [] coordArray)
{
    for (int i = 0; i < arrayToProcess.GetLength(0); i++)
        arrayToProcess[i, coordArray[1]] = 0;

    for (int j = 0; j < arrayToProcess.GetLength(1); j++)   
        arrayToProcess[coordArray[0], j] = 0;
    return arrayToProcess;
}

Console.Write("Input count of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of columns: ");
int userColumns = Convert.ToInt32(Console.ReadLine());

int [,] arrayFromUser = Created2dArray(userRows, userColumns);
ShowArray(arrayFromUser);
int [] coordUser = FindFirstMin(arrayFromUser);
int [,] finalArray = arrayToDemonstrate(arrayFromUser, coordUser);
ShowArray(finalArray);