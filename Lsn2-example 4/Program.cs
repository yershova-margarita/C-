// метод void - ничего не возвращает
void FillArray(int[] collection)
{
    int length = collection.Length;
    int i = 0;
    while (i < length)
    {
        collection[i] = new Random().Next(1, 10);
        i++;
    }
}

void PrintArray(int[] mass)
{
    int count = mass.Length;
    int i = 0;
    while (i < count)
    {
        Console.Write(mass[i] + ", ");
        i++;
    }
}

int IndexOf(int[] massive, int find)
{
    int count = massive.Length;
    int i = 0;
    int position = -1;
    while (i < count)
    {
        if (massive[i] == find)
        {
            position = i;
            break;
        }
        i++;
    }
    return position;
}
int [] myArray = new int[10];
FillArray(myArray);
PrintArray(myArray);

int pos = IndexOf(myArray, 4);
Console.WriteLine();
Console.WriteLine(pos);