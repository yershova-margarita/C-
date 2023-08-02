/*
Напишите программу, которая
принимает на вход число (А) и выдаёт сумму чисел
от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        checked        // работа с исключениями, чтобы не выйти за разрядность сетки
        {
            sum += i; //sum = sum + i;
        }
    }
    return sum;
}

Console.WriteLine("Введите натуральное число А :");
int userNum = Convert.ToInt32(Console.ReadLine());

if (userNum > 0)
{
    Console.WriteLine($"Сумма чисел от 1 до {userNum} : {SumNumbers(userNum)}");
}
else
{
    Console.WriteLine($"Введенное число {userNum} не является натуральным, повторите ввод");
}