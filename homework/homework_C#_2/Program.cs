// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

void find_second_digit()
{
    Console.Write("Input three digit number: ");
    int user_number = Convert.ToInt32(Console.ReadLine());
    if (user_number > 99 && user_number < 1000)
    {
        int two_digit = user_number % 100;
        int second_digit = two_digit / 10;
        Console.WriteLine($"The second digit of the number is {second_digit}");
    }
    else
    {
        Console.WriteLine("Your number is not three-digit");
    }
}
find_second_digit();

// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Способ для конкретных разрядов:
void find_third_digit()
{
    int random_number = new Random().Next(0, 100000);
//  для проверки:
//    int random_number = 34;
//    int random_number = 345;
//    int random_number = 3456;
//    int random_number = 34567;
    Console.WriteLine($"Number is {random_number}");
    if (random_number < 100)
    {
        Console.WriteLine("The number does not have a third digit");
    }
    else if (random_number >= 100 && random_number < 1000)
    {
        int digit_of_3 = random_number % 10;
        Console.WriteLine($"The third digit of the number is {digit_of_3}");
    }
    else if (random_number >= 1000 && random_number <= 10000)
    {
        int digit_of_4 = random_number / 10;
        int digit_of_3 = digit_of_4 % 10;
        Console.WriteLine($"The third digit of the number is {digit_of_3}");
    }
    else if (random_number >= 10000 && random_number < 100000)
    {
        int digit_of_5 = random_number / 100;
        int digit_of_3 = digit_of_5 % 10;
        Console.WriteLine($"The third digit of the number is {digit_of_3}");
    }
}
find_third_digit();

// Универсальный способ через приведение к строке
void FIND_THIRD_DIGIT()
{
    int RANDOM_NUMBER = new Random().Next(0, 1000000000);
    Console.WriteLine($"Number is {RANDOM_NUMBER}");
    if (RANDOM_NUMBER < 100)
    {
        Console.WriteLine("The number does not have a third digit");
    }
    else
    {
        string THIRD_DIGIT = RANDOM_NUMBER.ToString();
        Console.WriteLine($"The third digit of the number is {THIRD_DIGIT[2]}");
    }
}
FIND_THIRD_DIGIT();

// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void week()
{
    Console.Write("Input the day of the week in numerical format: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0 && number < 8)
    {
        if (number == 6 || number == 7)
        {
            Console.WriteLine("This day is a day off");
        }
        else
        {
            Console.WriteLine("This day is a weekday");
        }
    }
    else
    {
        Console.WriteLine("Enter the correct number");
    }
}
week();