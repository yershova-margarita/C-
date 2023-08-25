double Factorial(int n)
{
    if (n == 0) return 1;
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
Console.WriteLine("Введите число: ");
int userNum = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < userNum; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}