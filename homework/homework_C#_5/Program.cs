// Чтобы не прописывать внутри заданий 1 и 2 эти функции, я вынес их в голову файла

int[] CreateArray(int size, int min_val, int max_val)
{
    int[] new_array = new int[size];
    for (int i = 0; i < size; i++)
    {
        new_array[i] = new Random().Next(min_val, max_val + 1);
    }
    return new_array;
}

void PrintArray(int[] array_to_print)
{
    for (int i = 0; i < array_to_print.Length; i++)
    {
        Console.Write(array_to_print[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите размер массива: ");
int array_size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начальный элемент массива: ");
int array_min_val = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечный элемент массива: ");
int array_max_val = Convert.ToInt32(Console.ReadLine());


// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] first_array = CreateArray(array_size, array_min_val, array_max_val);

int FindSumEnum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i += 1)
    {
        if (array[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}
/*
PrintArray(first_array);
Console.WriteLine(); 
*/ // для проверки
Console.WriteLine($"Количество чётных чисел в массиве: {FindSumEnum(first_array)}");
Console.WriteLine();


// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] second_array = CreateArray(array_size, array_min_val, array_max_val);

int FindSumOddPos(int[] array)
{
    int sum_pos = 0;
    for (int i = 0; i < array.Length; i += 1)
    {
        if (i % 2 != 0)
        {
            sum_pos += array[i];
        }
    }
    return sum_pos;
}
/*
PrintArray(second_array);
Console.WriteLine(); 
*/ // для проверки
Console.WriteLine($"Сумма элементов, стоящих на нечётной позиции, равна {FindSumOddPos(second_array)}");
Console.WriteLine(); 


// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] CreateDoubleArray(int size, double min_val, double max_val)
{
    double[] new_array = new double[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        double randomValue = random.NextDouble() * (max_val - min_val) + min_val;
        new_array[i] = Math.Round(randomValue, 1);
    }

    return new_array;
}

void PrintDoubleArray(double[] array_to_print)
{
    for (int i = 0; i < array_to_print.Length; i++)
    {
        Console.Write(array_to_print[i] + " ");
    }
    Console.WriteLine();
}

double FindMaxDoubleArray(double[] array)
{
    double max_number = 0;
    for (int i = 0; i < array.Length; i += 1)
    {
        if (array[i] > max_number)
        {
            max_number = array[i];
        }
    }
    return max_number;
}

double FindMinDoubleArray(double[] array)
{
    double min_number = FindMaxDoubleArray(array);
    for (int i = 0; i < array.Length; i += 1)
    {
        if (array[i] < min_number)
        {
            min_number = array[i];
        }
    }
    return min_number;
}

int size_array = 5;
double minimum = 1.0;
double maximum = 100.0;
double[] third_array = CreateDoubleArray(size_array, minimum, maximum);
double max_number_array = FindMaxDoubleArray(third_array);
double min_number_array = FindMinDoubleArray(third_array);

/*
PrintDoubleArray(third_array);
Console.WriteLine();
Console.WriteLine(max_number_array);
Console.WriteLine(" -");
Console.WriteLine(min_number_array);
Console.WriteLine(" =");
*/ // для проверки
Console.WriteLine($"Разница между максимальным и мнимальным элементами массива -> {max_number_array - min_number_array}");