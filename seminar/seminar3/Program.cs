//Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int Coord(int x, int y)
{
    int quater = 0;
    if (x > 0 && y > 0)
    {
        quater = 1;
    }
    else if (x > 0 && y < 0)
    {
        quater = 4;
    }
    else if (x < 0 && y < 0)
    {
        quater = 3;
    }
    else if (x < 0 && y > 0)
    {
        quater = 2;
    }
    else
    {
        quater = 0;
    }
    return quater;
}
Console.WriteLine("Введите значение координаты x: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение координаты y: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Coord(number1, number2));


//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

int Quater(int quater)
{
    if (quater == 1)
    {
        Console.WriteLine($"Для четверти {quater} диапазон коориднат:");
        Console.WriteLine($"x > 0; y > 0");
    }
    else if (quater == 2)
    {
        Console.WriteLine($"Для четверти {quater} диапазон коориднат:");
        Console.WriteLine($"x < 0; y > 0");
    }
    else if (quater == 3)
    {
        Console.WriteLine($"Для четверти {quater} диапазон коориднат:");
        Console.WriteLine($"x < 0; y < 0");
    }
    else if (quater == 4)
    {
        Console.WriteLine($"Для четверти {quater} диапазон коориднат:");
        Console.WriteLine($"x > 0; y < 0");
    }
    else
    {
        Console.WriteLine("Некорректное значение четверти:");
    }
    return quater;
}
Console.Write("Введите номер четверти: ");
int QUATER = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Quater(QUATER));


//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D пространстве.
// A(x1,y1); B(x2,y2)

double long_line_ab (int xA, int xB, int yA, int yB)
{
    double long_line = Math.Sqrt((xB - xA)*(xB - xA) + (yB - yA)*(yB - yA)); // вызов из библиотеки Math корня Sqrt
    double longline = Math.Round(long_line, 2);
    return longline;
}
Console.Write("Введите координату X точки A: ");
int x_coord_A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки A: ");
int y_coord_A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X точки B: ");
int x_coord_B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
int y_coord_B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Расстояние от точки A до точки B: {long_line_ab(x_coord_A, x_coord_B, y_coord_A, y_coord_B)}");


//Напишите программу, которая принимает на вход число (N) и 
//выдаёт ряд квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4.

void Find(int number)
{
    int count = 0;
    while (count <= number)
    {
        double result = Math.Pow(count, 2); // Вывод из библиотеки Math возведение в степень Pow
        Console.Write($"{result:f0}, ");
        count += 1;
    }
    Console.WriteLine("\b\b."); // для точки в конце
}
Find(5);