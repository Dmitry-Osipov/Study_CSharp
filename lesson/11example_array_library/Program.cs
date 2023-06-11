int[] Array = new int[10]; // дословно - создай новый массив, в котором будет 10 элементов

void FillArray(int[] collection) 
{
     int lenght = collection.Length;
     int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index += 1;
    }
} 

void PrintArray(int[] col)
{
    int count = col.Length;
    int postion = 0;
    while (postion < count)
    {
        Console.WriteLine(col[postion]);
        postion += 1;
    }
}


FillArray(Array);
PrintArray(Array);
Console.WriteLine();

int IndexOf(int[] collec, int FIND)
{
    int COUNT = collec.Length;
    int INDEX = 0;
    int POSITION = -1; // это искуственный приём. Если элемента нет, то вернётся -1
    while (INDEX < COUNT)
    {
        if (collec[INDEX] == FIND)
        {
            POSITION = INDEX;
            break; // вывод первой же позиции четвёрки, если убрать break, то выведется последняя
        }
        INDEX += 1;
    }
    return POSITION;
}

int pos = IndexOf(Array, 4);
Console.WriteLine(pos);