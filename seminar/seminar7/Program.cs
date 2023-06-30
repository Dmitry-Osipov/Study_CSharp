// Задайте двумерный массив размером m * n, заполненный случайными числами

int[,] Create2DArray()
{
    Console.WriteLine("Enter count of rows: ");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count of collums: ");
    int userCollums = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter min possible value: ");
    int userMin = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter max possible value: ");
    int userMax = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] created2dArray = new int [userRows, userCollums];
    for (int i = 0; i < userRows; i += 1)
    {
        for (int j = 0; j < userCollums; j += 1)
        {
            created2dArray[i, j] = new Random().Next(userMin, userMax + 1);
        }
    }
    return created2dArray;
}

void Print2DArray(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i += 1)
    {
        for (int j = 0; j < array2d.GetLength(1); j += 1)
        {
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] new2dArray = Create2DArray();
Print2DArray(new2dArray);

// /*Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3      [0,0] [0,1] [0,2] [0,3]  
// 1 2 3 4      [1,0] [1,1] [1,2] [1,3]
// 2 3 4 5
// */

int[,] Fill2DArray()
{
    int userRows = 3;
    int userCollums = 4;
    int[,] filled2dArray = new int[userRows, userCollums];
    for (int i = 0; i < filled2dArray.GetLength(0); i += 1)
    {
        for (int j = 0; j < filled2dArray.GetLength(1); j += 1)
        {
            filled2dArray[i, j] = i + j;
        }
    } 
    return filled2dArray;
}

int[,] second2dArray = Fill2DArray();
Print2DArray(second2dArray);

//Задайте двумерный вещественный массив. Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.

void Print2DArrayDouble(double[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i += 1)
    {
        for (int j = 0; j < array2d.GetLength(1); j += 1)
        {
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] Create2DArray()
{
    Console.WriteLine("Enter count of rows: ");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count of collums: ");
    int userCollums = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter min possible value: ");
    int userMin = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter max possible value: ");
    int userMax = Convert.ToInt32(Console.ReadLine());

    double[,] created2dArray = new double [userRows, userCollums];
    for (int i = 0; i < userRows; i += 1)
    {
        for (int j = 0; j < userCollums; j += 1)
        {
            created2dArray[i, j] =Math.Round((new Random().Next(userMin, userMax + 1) + new Random().NextDouble()), 2);
        }
    }
    return created2dArray;
}

double[,] ModiArray(double[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i += 1)
    {
        for (int j = 0; j < array2d.GetLength(1); j += 1)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array2d[i, j] *= array2d[i, j];
            }
        }
    }
    return array2d;
}

double[,] thirdArray2d = Create2DArray();
Print2DArrayDouble(thirdArray2d);
double[,] modiThirdArray2d = ModiArray(thirdArray2d);
Print2DArrayDouble(modiThirdArray2d);

// Дан двумерный массив. Вывести на экран:
// а) все элементы пятой строки массива;
// б) все элементы s-го столбца массива.

void Print5Line(int[,] array2d)
{
    for (int j = 0; j < array2d.GetLength(1); j += 1)
    {
        Console.WriteLine(array2d[4, j] + " ");
    }
}

void PrintUserCollums(int[,] array2d)
{
    Console.WriteLine("Enter number of collums: ");
    Console.WriteLine();
    int user = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < array2d.GetLength(0); i += 1)
    {
        Console.WriteLine(array2d[i, user] + " ");
    }
}

int[,] taskArray = Create2DArray();
Print2DArray(taskArray);
Console.WriteLine();
Print5Line(taskArray);
Console.WriteLine();
PrintUserCollums(taskArray);

//Дан двумерный массив. Найти:
// среднее арифметическое элементов, расположенных в четырех углах.

int[,] newTaskArray = Create2DArray();
Print2DArray(newTaskArray);

double AvgArray(int[,] array2d)
{
    double sum = Math.Round((array2d[0,0] + 
                array2d[array2d.GetLength(0) - 1, (array2d.GetLength(1) - 1)] +
                array2d[array2d.GetLength(0) - 1, 0] +
                array2d[0, array2d.GetLength(1) - 1]) / 4.0, 2);
    return sum;                
}

Console.WriteLine($"{AvgArray(newTaskArray)}");
