// напишите программу, которая на вход принимает 
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N
Console.WriteLine("Введите натуральное число");
int userNum = Convert.ToInt32(Console.ReadLine());
if (userNum > 0)
{
    // for (int i = -userNum; i <= userNum; i++)
    // {
    //     Console.Write($"{i}, ");
    // }
    int count = -userNum;
    while (count <= userNum)
    {
        Console.Write($"{count}, ");
        count++;
    }
}
else
{
    Console.Write($"Число {userNum} не является натуральным");
}