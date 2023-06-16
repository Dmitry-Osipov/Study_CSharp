// Задача 1: Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.

void Number(int number)
{
    int first_digit = number / 10000;
    int last_digit = number % 10;
    int second_digit = number / 1000 % 10;
    int penultimate_digit = number % 100 / 10;
    if (first_digit == last_digit && second_digit == penultimate_digit)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Даннаое число не является палиндромом");
    }
}


Console.Write("Введите пятизначное число: ");
int user_number = Convert.ToInt32(Console.ReadLine());
if (user_number > 0)
{
    if (user_number >= 10000 && user_number <= 99999)
    {
        Number(user_number);
    }
    else
    {
        Console.WriteLine("Требуется ввести пятизначное число");
    }
}
else
{
    if (user_number <= -10000 && user_number >= -99999)
    {
        user_number *= (-1);
        Number(user_number);
    }
    else
    {
        Console.WriteLine("Требуется ввести пятизначное число");
    }
}

// Задача 2: Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

double Coord(int xA, int xB, int yA, int yB, int zA, int zB)
{
    double distance = Math.Sqrt((xA - xB) * (xA - xB) + (yA - yB) * (yA - yB) + (zA - zB) * (zA - zB));
    return distance;
}


Console.Write("Введие координату X для точки A: ");
int x_coord_a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введие координату X для точки B: ");
int x_coord_b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введие координату Y для точки A: ");
int y_coord_a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введие координату Y для точки B: ");
int y_coord_b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введие координату Z для точки A: ");
int z_coord_a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введие координату Z для точки B: ");
int z_coord_b = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"Расстояние от точки A до точки B: {Coord(x_coord_a, x_coord_b, y_coord_a, y_coord_b, z_coord_a, z_coord_b)}");

// Задача 3: Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

void Cube(int number)
{
    int count = 0;
    if (number > 0)
    while (count <= number)
    {
        Console.Write($"{count * count * count}, ");
        count += 1;
    }
    else
    {
        while (count >= number)
        {
            Console.Write($"{count * count * count}, ");
            count -= 1;
        }
    }
    Console.WriteLine("\b\b.");
}

Console.Write("Введите число: ");
int USER_NUMBER = Convert.ToInt32(Console.ReadLine());
Cube(USER_NUMBER);
