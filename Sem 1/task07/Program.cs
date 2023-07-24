// напишите программу, которая принимает на вход
// трехзначное число и на выходе показывает
// последнюю цифру этого числа
Console.WriteLine("Введите трехзначное целое число");
int userNum = Convert.ToInt32(Console.ReadLine());
if ((userNum >= 100 && userNum <= 999) || (userNum >= -999 && userNum <= -100))
{
    // последнюю цифру этого числа
    int resultLast = userNum % 10;
    // первую цифру этого числа
    int resultFirst = userNum / 100;
    // вторую цифру этого числа
    int resultSecond = userNum / 10 % 10;
    Console.WriteLine($"Первая цифра числа {userNum} - {resultFirst}");
    Console.WriteLine($"Вторая цифра числа {userNum} - {resultSecond}");
    Console.WriteLine($"Последняя цифра числа {userNum} - {resultLast}");
}
else
{
    Console.WriteLine("Число не является трехзначным");
}

// первую цифру этого числа