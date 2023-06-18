void Method1()
{
    Console.WriteLine("Osipov D.R.");
}
Method1();


void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Hello");


void Method2_1(string hello, string name)
{
    Console.WriteLine(hello + name);
}
Method2_1(name: "stranger", hello: "How are you, ");


int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);


string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result += c;
        i += 1;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);


string Method4_1(int count, string c)
{
    string result = String.Empty;
    for (int i = 0; i < count; i += 1) // Инициалиация счётчика, условие, инкремент
    {
        result += c; // Что нужно сделать
    }
    return result;
}
string RESULT = Method4_1(5, "ghjk");
Console.WriteLine(RESULT);


for (int i = 2; i <= 10; i += 1)
{
    for (int j = 2; j <= 10; j += 1)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}

/*
Работа с текстом. Дан текст. В тексте нужно все пробелы заменить чёрточками, маленькие буквы "к" 
заменить большими буквами "K", а большие "C" заменить маленькими "c"
*/
string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char old_value, char new_value)
{
    string result = String.Empty;

    int lenght = text.Length;
    for (int i = 0; i < lenght; i += 1)
    {
        if (text[i] == old_value) result += $"{new_value}";
        else result += $"{text[i]}";
    }

    return result;
}
string new_text = Replace(text, ' ', '|');
Console.WriteLine(new_text);
string new_text_1 = Replace(new_text, 'к', 'К');
Console.WriteLine(new_text_1);
string new_text_2 = Replace(new_text_1, 'C', 'c');
Console.WriteLine(new_text_2);


int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i += 1)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i += 1)
    {
        int min_pos = i;

        for (int j = i + 1; j < array.Length; j += 1)
        {
            if(array[j] < array[min_pos]) min_pos = j;
        }

        int temporary = array[i];
        array[i] = array[min_pos];
        array[min_pos] = temporary;
    }
}
SelectionSort(arr);
PrintArray(arr);