/*
Напишите программу, которая
принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N.
*/

void SqrtTable(int n) 
{
    for (int i = 1; i <= n; i++) 
    {
        double sqrt = Math.Pow(i,2);
        Console.WriteLine($"{i}  {sqrt}");
    }
}

Console.WriteLine("Введите науральное число : ");
int userNum = Convert.ToInt32(Console.ReadLine());

if (userNum < 1)
{
    Console.WriteLine("Вы ввели не натуральное число, повторите ввод");
}
SqrtTable(userNum);