// Напишите программу, которая перевернёт одномерный массив

int[] CreateNewArray(int size, int min_val, int max_val)
{
    int[] new_array = new int [size];
    for (int i = 0; i < new_array.Length; i += 1)
    {
        new_array[i] = new Random().Next(min_val, max_val + 1);
    }
    return new_array;
}

void PrintArray(int[] array_to_show)
{
    for (int i = 0; i < array_to_show.Length; i += 1)
    {
        Console.Write(array_to_show[i]);
        if (i != array_to_show.Length - 1) Console.Write(", ");
        else Console.WriteLine(".");
    }
    Console.WriteLine();
}

int[] ReverseArray(int[] array_to_reverse)
{
    int size = array_to_reverse.Length;
    for (int i = 0; i < size/2; i += 1)
    {
        int temp = array_to_reverse[i];
        array_to_reverse[i] = array_to_reverse[size - 1 - i];
        array_to_reverse[size - 1 - i] = temp;
    }
    return array_to_reverse;
}

int[] first_array = CreateNewArray(5, 1, 10);
PrintArray(first_array);
int [] reversed_first_array = ReverseArray(first_array);
PrintArray(reversed_first_array);


//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3  -> 11

int CountOfBinar(int user_number)
{
    int count = 0;
    while (user_number != 0)
    {
        user_number /= 2;
        count += 1; 
    }
    return count;
}

int[] ConversionToBinar(int num_to_convert)
{
    int n = CountOfBinar(num_to_convert);
    int[] binar_array = new int[n];
    for (int i = n - 1; i >= 0; i -= 1)
    {
        binar_array[i] = num_to_convert % 2;
        num_to_convert /= 2;
    }
    return binar_array;
}

int my_number = 45;
int count_element = CountOfBinar(my_number);
int[] binar = ConversionToBinar(my_number);
PrintArray(binar);


// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: a и b вводит пользователь

void FibonacciSomeNumber(int number_to_stop, int min_val, int max_val)
{
    int[] array_fib = new int[number_to_stop];
    array_fib[0] = min_val;
    array_fib[1] = max_val;
    for (int i = 2; i < number_to_stop; i += 1)
    {
        array_fib[i] = array_fib[i - 1] + array_fib[i - 2];
    }
    PrintArray(array_fib);
}

Console.WriteLine("Enter count of elements: ");
int user_count = Convert.ToInt32(Console.ReadLine());
if (user_count >= 2)
{
    Console.WriteLine("Enter first element: ");
    int user_number_min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter last element: ");
    int user_number_max = Convert.ToInt32(Console.ReadLine());
    FibonacciSomeNumber(user_count, user_number_min, user_number_max);
}
else
{
    Console.WriteLine("Impossible value");
}


// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// каждая сторона треугольника меньше суммы двух других сторон. Решите с помощью массива

void Triagle(int a, int b, int c)
{
    int[] my_triagle = {a, b, c};
    if (my_triagle[0] < my_triagle[1] + my_triagle[2] && my_triagle[1] < my_triagle[0] + my_triagle[2] && my_triagle[2] < my_triagle[0] + my_triagle[1])
    {
        Console.WriteLine($"Triangle {my_triagle[0]} {my_triagle[1]} {my_triagle[2]} exist");
    }
    else
    {
        Console.WriteLine($"Triangle {my_triagle[0]} {my_triagle[1]} {my_triagle[2]} DO NOT exist");
    }
}

Console.Write("Input first side: ");
int first_side = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second side: ");
int second_side = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third side: ");
int third_side = Convert.ToInt32(Console.ReadLine());
Triagle(first_side, second_side, third_side);


