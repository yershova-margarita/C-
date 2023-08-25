void PrintArray(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            Console.Write($"{matrix[rows, cols]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            matrix[rows, cols] = new Random().Next(1, 10); // [1,10)
        }
    }
}

int[,] userMatrix = new int[3, 4];
PrintArray(userMatrix);
FillArray(userMatrix);
Console.WriteLine();
PrintArray(userMatrix);