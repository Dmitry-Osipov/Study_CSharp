// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

int[] CreateArray(int size, int min_val, int max_val)
{
    int[] new_array = new int [size];
    for (int i = 0; i < size; i += 1)
    {
        new_array[i] = new Random().Next(min_val, max_val + 1);
    }
    return new_array;
}

void PrintArray(int[] array_to_print)
{
    for (int i = 0; i < array_to_print.Length; i += 1)
    {
        Console.Write(array_to_print[i] + " ");
    }
    Console.WriteLine();
}

void FindSumNegElem(int[] array)
{
    int sum_neg_elem = 0;
    for (int i = 0; i < array.Length; i += 1)
    {
        if (array[i] < 0)
        {
            sum_neg_elem += array[i];
        }
    }
    Console.WriteLine($"Сумма отрицательных значений массива: {sum_neg_elem}");
}

int FindSumPosElem(int[] array)
{
    int sum_pos_elem = 0;
    for (int i = 0; i < array.Length; i += 1)
    {
        if (array[i] > 0)
        {
            sum_pos_elem += array[i];
        }
    }
    return sum_pos_elem;
}

int[] new_array = CreateArray(12, -9, 9);
PrintArray(new_array);
Console.WriteLine();
FindSumNegElem(new_array);
Console.WriteLine();
Console.WriteLine($"Сумма положительных значений массива: {FindSumPosElem(new_array)}");


// Задача 2: Напишите программу замены элементов массива: положительные элементы замените
// на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] CreateArray()
{
    int[] random_array = new int [4];
    for (int i = 0; i < 4; i += 1)
    {
        random_array[i] = new Random().Next(-10, 11);
    }
    return random_array;
}

void PrintArray(int[] array_to_print)
{
    for (int i = 0; i < array_to_print.Length; i += 1)
    {
        Console.Write(array_to_print[i] + " ");
    }
    Console.WriteLine();
}

int[] UpdateArray (int[] array_to_update)
{
    for (int i = 0; i < array_to_update.Length; i += 1)
    {
        array_to_update[i] *= (-1);
    }
    return array_to_update;
}

int[] new_array = CreateArray();
int[] updated_array = UpdateArray(new_array);
PrintArray(new_array);
Console.WriteLine();
PrintArray(updated_array);


// Задача 3: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
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

void Main()
{
    int[] old_array = CreateArray(5, 1, 11);
    int size = old_array.Length;

    PrintArray(old_array);

    int[] new_array = new int[(size + 1) / 2];
    int middleIndex = size / 2;
    for (int i = 0; i < (size + 1) / 2; i++)
    {
        if (size % 2 != 0 && i == middleIndex)
        {
            new_array[i] = old_array[i];
        }
        else
        {
            new_array[i] = old_array[i] * old_array[size - i - 1];
        }
    }

    PrintArray(new_array);
}

Main();


// Задача 4:Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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

int[] my_array = CreateArray(123, 1, 201);

int CountArray(int[] array_to_count)
{
    int count = 0;
    for (int i = 0; i < array_to_count.Length; i += 1)
    {
        if (array_to_count[i] >= 10 && array_to_count[i] <= 99)
        {
            count += 1;
        }
    }
    return count;
}
int count_array = CountArray(my_array);
PrintArray(my_array);
Console.WriteLine(count_array);

