string[,] table = new string[2, 5]; // 2 строчки 5 столбцов
table[1, 2] = "word"; // обращаемся к конкретнй позиции по строке и столбцу. Отсчёт начинается с 0
for (int rows = 0; rows < 2; rows += 1)
{
    for (int colums = 0; colums < 5; colums += 1)
    {
        Console.WriteLine($"-{table[rows, colums]}-");
    }
}


int[,] matrix = new int[3, 4]; // обязательно оставлять значение в цифрах для выделения памяти. Однако если массив заранее задан, то указывать значения внутри квадратных скобок не требуется

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i += 1)
    {
        for (int j = 0; j < matr.GetLength(1); j += 1)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i += 1) // чтобы получить пеерсчёт строки или столбца нужно указать цифру, вызвав метод array.GetLength()
    {
        for (int j = 0; j < matr.GetLength(1); j += 1) // для строки цифра 0, для столбца цифра 1 
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);


void PrintImage(int[,] image) // для зарисовки контура массива плюсами
{
    for (int i = 0; i < image.GetLength(0); i += 1)
    {
        for (int j = 0; j < image.GetLength(1); j += 1)
        {
            if (image[i, j] == 0) Console.Write(" "); // ставим пробел, если в массиве указан 0
            else Console.Write("+"); // ставим +, где нужно
        }
        Console.WriteLine();
    }
}

void FillEmage(int row, int colum) // в качестве аргумента указали старт для закрашивания
{
    if (image[row, colum] == 0) // Рекурсия должна быть подконтрольна/иметь выход
    {
        image[row, colum] = 1;
        FillEmage(row-1, colum); // Функция вызывает саму себя
        FillEmage(row, colum-1);
        FillEmage(row+1, colum);
        FillEmage(row1, colum+1);
    }
}


double Factorial (int number)
{
    if (number == 1) return 1;
    else return number * Factorial(number - 1);
}
Console.Write(Factorial(40));


// f(1) = 1 f(2) = 1 f(n) = f(n-1) + f(n-2)

double Fibonacci(int number)
{
    if (number == 1 || number == 2) return 1;
    else return Fibonacci(number - 1) + Fibonacci(number - 2);
}

for (int i = 1; i < 50; i += 1)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}