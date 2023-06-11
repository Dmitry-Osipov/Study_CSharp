int[] Array = {1, 24, 32 ,41 ,57 ,634 ,71 ,78};

int n = Array.Length;
int find = 41;

int index = 0;

while (index < n)
{
    if (Array[index] == find)
    {
        Console.WriteLine(index);
    }
    index += 1;
}