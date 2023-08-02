/*
Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

int CountDigit(int num)
{
    int count = 0;
    if (num == 0) 
    { 
        count = 1;
    }
    else {
        while (num != 0)
        {
            num = num / 10;
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите натуральное число : ");
int userNum = Convert.ToInt32(Console.ReadLine());

int result = CountDigit(userNum);
Console.WriteLine($"Количество цифр в числе {userNum} : {result}");