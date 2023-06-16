/*
Console.WriteLine("Today is Friday");
Console.Write("Today is Friday");
*/
// /**/ - закомментировать часть кода


//Console.ReadLine("Input : "); // str

Console.Write("Input number: ");
int user_number = Convert.ToInt32(Console.ReadLine()); // int
Console.WriteLine("Your number is - " + user_number);
Console.WriteLine($"Your number is - {user_number}");



// Задача 1:
// Напишите прошрамму, которая принимает число и выдаёт его квадрат
// 1. Узнайте у пользователя число
// 2. Вводим в квадрат
// 3. Выводим результат
Console.Write("Input number: "); // 1 шаг
int user_number = Convert.ToInt32(Console.ReadLine()); // 1 шаг
int user_number_sqr = user_number * user_number; // 2 шаг
Console.WriteLine(user_number_sqr); // 3 шаг



// Задача 2: 
// Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.
Console.Write("Input number 1: ");
int number_1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input number 2: ");
int number_2 = Convert.ToInt32(Console.ReadLine()); 
if (number_2 == number_1 * number_1)
{
    Console.WriteLine($"{number_2} IS square of {number_1}");
}
else
{
    Console.WriteLine($"{number_2} IS NOT square of {number_1}");
}



// Задача 3:
// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.
Console.Write("Input positive number: ");
int user_number = Convert.ToInt32(Console.ReadLine());
int another_user_number = user_number * -1;
int count = another_user_number;
while (count <= user_number)
{
    Console.WriteLine(count);
    count += 1;
}



// Задача 4:
// Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает последнюю цифру этого числа.
Console.Write("Input three-digit number: ");
int user_number = Convert.ToInt32(Console.ReadLine());
if (user_number > 99 && user_number < 1000)
{
    int last_number = user_number % 10;
    Console.WriteLine($"Last number of {user_number} is {last_number}");
}
else
{
    Console.WriteLine("Yout number is not three-digit number");
}