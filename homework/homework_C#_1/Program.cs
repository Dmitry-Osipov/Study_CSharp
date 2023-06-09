//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Task: find max number");
Console.Write("Input number_1: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number_2: ");
int number_2 = Convert.ToInt32(Console.ReadLine());
if (number_1 > number_2)
{
    Console.WriteLine($"max = {number_1}");
}
else
{
    Console.WriteLine($"max = {number_2}");
}

//Задача 2: Напишите программу, которая принимает на вход три числа и
// выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Task: find max number of 3 numbers");
Console.Write("Input number_1: ");
int new_number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number_2: ");
int new_number_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number_3: ");
int new_number_3 = Convert.ToInt32(Console.ReadLine());
if (new_number_1 > new_number_2 && new_number_1 > new_number_3)
{
    Console.WriteLine($"max = {new_number_1}");
}
if (new_number_2 > new_number_1 && new_number_2 > new_number_3)
{
    Console.WriteLine($"max = {new_number_2}");
}
if (new_number_3 > new_number_1 && new_number_3 > new_number_2)
{
    Console.WriteLine($"max = {new_number_3}");
}

//Задача 3: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Task: find even or odd number");
Console.Write("Input number: ");
int user_number = Convert.ToInt32(Console.ReadLine());
if (user_number % 2 == 0)
{
    Console.WriteLine("Your number is even");
}
else
{
    Console.WriteLine("Your number is odd");
}

//Задача 4: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Task: output all even numbers in count of user_number");
Console.Write("Input number: ");
int new_user_number = Convert.ToInt32(Console.ReadLine());
int count = 1;
if (new_user_number >= 2)
{
while (count <= new_user_number)
    {
        if (count % 2 == 0)
        {
            Console.WriteLine(count);
            count += 1;
        }
        else
        {
            count += 1;
        }
    }
}
else
if (new_user_number < 2)
{
    while (count >= new_user_number)
    {
        if (count % 2 == 0)
        {
            Console.WriteLine(count);
            count -= 1;
        }
        else
        {
            count -= 1;
        }
    }
}