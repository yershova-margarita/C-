/*
Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

int FactorialOfNumbers(int num)
{
    int fact = 1;
    // for (int i = 1; i <= num; i++)
    // {
    //     checked        // работа с исключениями, чтобы не выйти за разрядность сетки
    //     {
    //         fact *= i; // fact = fact * i;
    //     }
    // }
    while (num !=0 )
    {
        fact *= num;
        num --;
    }
    return fact;
}

Console.WriteLine("Введите натуральное число А :");
int userNum = Convert.ToInt32(Console.ReadLine());

if (userNum > 0)
{
    Console.WriteLine($"Произведение чисел от 1 до {userNum} : {FactorialOfNumbers(userNum)}");
}
else
{
    Console.WriteLine($"Введенное число {userNum} не является натуральным, повторите ввод");
}