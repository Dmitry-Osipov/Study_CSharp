int[] Array = {1, 2, 31, 676, 7878, 9929, 3632, 8772, 782672};
Array[0] = 13;
int Max(int number1, int number2, int number3)
{
    int result = number1;
    if (number2 > result) result = number2;
    if (number3 > result) result = number3;
    return result;
}

int max = Max(
    (Max(Array[0], Array[1], Array[2])), 
    (Max(Array[3], Array[4], Array[5])),
    (Max(Array[6], Array[7], Array[8])));

Console.WriteLine(max);