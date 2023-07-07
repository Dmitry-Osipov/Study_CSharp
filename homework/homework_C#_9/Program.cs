// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке
// от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void CounterFromNumberToOne (int number)
{
    if (number >= 1)
    {
        Console.Write(number + " ");
        CounterFromNumberToOne(number - 1);
    }
}

CounterFromNumberToOne(8);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int FindSumInNumber(int firstNumber, int secondNumber)
{
    if (firstNumber == secondNumber)
    {
        return firstNumber;
    }
    else if (firstNumber >= secondNumber)
    {
        return secondNumber;
    }
    int middle = (firstNumber + secondNumber) / 2;
    int sumLeft = FindSumInNumber(firstNumber, middle);
    int sumRight = FindSumInNumber(middle + 1, secondNumber);
    return sumLeft + sumRight;
}

int M = 4;
int N = 8;
Console.WriteLine(FindSumInNumber(M, N));

// Задача 68*: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkermann (int firstNumber, int secondNumber)
{
    if (firstNumber == 0)
    {
        return secondNumber + 1;
    }
    else if (secondNumber == 0)
    {
        return Akkermann(firstNumber - 1, 1);
    }
    return Akkermann(firstNumber - 1, Akkermann(firstNumber, secondNumber - 1));
}

Console.Write(Akkermann(3, 2));
