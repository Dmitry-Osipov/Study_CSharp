// Задача 1: Напишите программу, которая принимает на вход число и выдаёт сумму чисел от 1 до этого числа

void FindSumm(int number)
{
    int result = 0;
    for (int count = 1; count <= number; count += 1)
    {
        result += count;
    }
    Console.WriteLine($"Сумма элементов от 1 до {number} = {result}");
}
Console.Write("Введите число: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number > 0)
{
    FindSumm(user_number);
}
else
{
    Console.WriteLine("Некорретное значение");
}

void FindSumm1(int number1)
{
    int result1 = 0;
    int count1 = 1;
    while (count1 <= number1)
    {
        result1 += count1;
        count1 += 1;
    }
    Console.WriteLine($"Сумма элементов от 1 до {number1} = {result1}");
}
Console.Write("Введите число: ");
int user_number1 = Convert.ToInt32(Console.ReadLine());

if (user_number1 > 0)
{
    FindSumm1(user_number1);
}
else
{
    Console.WriteLine("Некорретное значение");
}


// Задача 2: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

int SummDigit(int number)
{
    int count = 0;
    if (number >= 0)
    {
        while (number > 0)
        {
            number /= 10;
            count += 1;
        }
    }
    else
    {
        while (number < 0)
        {
            number /= 10;
            count += 1;
        }
    }
    return count;
}
Console.Write("Введите число: ");
int user_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SummDigit(user_number));


//Задача 3: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

int Factorial(int number)
{
    int result = 1;
    for (int count = 1; count <= number; count += 1)
    {
        result *= count;
    }
    return result;
}
Console.Write("Введите число > 0: ");
int user_number = Convert.ToInt32(Console.ReadLine());
if (user_number > 0)
{
    Console.WriteLine(Factorial(user_number));
}
else
{
    Console.WriteLine("0");
}


//Задача 4: Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

int[] CreateNewArray (int size_array) 
{
    int[] Random1Array = new int[size_array];
    for (int i = 0; i < size_array; i += 1)
    {
        Random1Array[i] = new Random().Next(0, 2);
    }
    return Random1Array;
}

void PrintArray(int[] ArrayToPrint)
{
    Console.WriteLine($"Ваш массив: ");
    for (int i = 0; i < ArrayToPrint.Length; i += 1)
    {
        Console.Write(ArrayToPrint[i] + " ");
    }
}

int size = 8;
int[] FirstArray = CreateNewArray(size);
PrintArray(FirstArray);