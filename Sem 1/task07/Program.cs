// напишите программу, которая принимает на вход
// трехзначное число и на ыходе показывает
// последнюю цифру этого числа
Console.WriteLine("Введите трехзначное целое число");
int userNum = Convert.ToInt32(Console.ReadLine());
if ((userNum >= 100 && userNum <= 999) || (userNum >= -999 && userNum <= -100))
{
    int result = userNum % 10;
    Console.WriteLine($"Последняя цифра числа {userNum} - {result}");
}
else
{
    Console.WriteLine("Число не является трехзначным");
}