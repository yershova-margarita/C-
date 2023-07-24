int [] exzArray = { 178, 200, 56, 94, 82, 467, 387, 677, 89 };
int count = exzArray.Length;
int find = 82;
int i = 0;
while (i < count)
{
    if(exzArray[i] == find)
    {
        Console.Write(i);
        break;
    }
    i++;
}