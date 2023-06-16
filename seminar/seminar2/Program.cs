// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру

int Line(){
    int num = new Random().Next(10, 100);
    Console.WriteLine("Your num is " + num);
    int dec = num / 10;
    int ed = num % 10;
    if (dec > ed){
        return dec;
    }
    else{
        return ed;
    }
}

Console.WriteLine($"Result is {Line()}");


// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

void Line(){
    int num = new Random().Next(100, 1000);
    Console.WriteLine("Your num is " + num);
    int first = num / 100;
    int third = num % 10;
    Console.Write($"{first}{third}");
}
Line();

// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

void NUMBERS()
{
    Console.Write("Введите число 1: ");
    int number_1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число 2: ");
    int number_2 = Convert.ToInt32(Console.ReadLine());
    if (number_2 % number_1 == 0)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else
    {
        Console.WriteLine(number_2 % number_1);
    }
}
NUMBERS();


// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23

void crat()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number != 0)
    {
        if (number % 7 == 0 && number % 23 == 0)
        {
            Console.WriteLine("Число кратно 7 и 23 одновременно");
        }
        else
        {
            Console.WriteLine("Число не кратно 7 и 23 одновременно");
        }
    }
}
crat();

// Напишите программу, которая принимает на вход 2 числа и проверяет, 
// является ли одно число квадратом другого

void Numbers()
{
    Console.Write("Введите число 1: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число 2: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    if (number1 < 0)
    {
        number1 *= (-1);
    }
    else if (number2 < 0)
    {
        number2 *= (-1);
    }
    Console.WriteLine($"{number1}, {number2}");
    if (number2 == number1 * number1 || number1 == number2 * number2)
    {
        Console.WriteLine("Одно число является квадратом другого числа");
    }
    else
    {
        Console.WriteLine("Ни одино число не является квадратом другого числа");
    }
}

Numbers();