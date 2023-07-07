// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

void ShowNumbers (int N)
{
    if (N > 1)
    {
        ShowNumbers(N - 1);
    }
    Console.Write(N + " ");
}

ShowNumbers(5);

// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void ShowWithTwoNumbers(int N, int M)
{
    if (N != M)
    {
        ShowWithTwoNumbers(Math.Min(N, M), Math.Max(N, M) - 1);
    }
    Console.Write($"{Math.Max(N, M)} ");
}

ShowWithTwoNumbers(10, 20);

// Напишите программу, котрая будет принимать на вход число и возвращать сумму его цифр

int SumDigitsFromNumber (int number)
{
    if (number < 0)
    {
        number *= (-1);
    }
    else if (number == 0)
    {
        return 0;
    }
    return number % 10 + SumDigitsFromNumber(number / 10);
}

Console.Write(SumDigitsFromNumber(1785872));

// Напишите программу, которая на вход принимает два числа А и В, и возводит число А в целую степень
// В с помощью рекурсии

double FindPow (int number, int pow)
{
    if (pow == 0) return 1.0;
    else if (pow > 0) return FindPow(number, pow - 1) * number;
    return FindPow(number, pow + 1) / number;
}

Console.Write(FindPow(2, -3));

// Напишите программу, которая на вход принимает положительное целое десятичное число, а на выходе
// переводит его в бинарный формат

// 4 -> 100
// 5 -> 101

string DecToByn (int number, ref string s)
{
    if (number > 0)
    {
        DecToByn (number / 2, ref s);
        s += (number % 2).ToString();
    }
    else if (number == 0) return s;
    return s;
}

Console.Write("Input number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
string s = "";
string result = DecToByn(userNumber,ref s);
Console.Write(result);
