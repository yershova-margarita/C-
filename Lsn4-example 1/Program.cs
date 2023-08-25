// массив строк
// string[,] myArr = new string[2, 3];

// матрица чисел
// int[,] myMatrix = new int[5, 8]; // 5 количество строк, 8 - столбцов

string[,] myArr = new string[2, 5];
// String.Empty
// myArr[0,0] myArr[0,1] myArr[0,2] myArr[0,3] myArr[0,4]
// myArr[1,0] myArr[1,1] myArr[1,2] myArr[1,3] myArr[1,4]
myArr[1, 2] = "слово";

Console.WriteLine("Первый пример");
for (int rows = 0; rows < 2; rows++)
{
    for (int cols = 0; cols < 5; cols++)
    {
        Console.Write($"- {myArr[rows,cols]} -");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Второй пример");
int[,] myMatrix = new int[3, 4];
for (int rows = 0; rows < myMatrix.GetLength(0); rows++)
{
    for (int cols = 0; cols < myMatrix.GetLength(1); cols++)
    {
        Console.Write($"{myMatrix[rows,cols]} ");
    }
    Console.WriteLine();
}