/*  Напишите программу, которая принимает на
вход два числа и проверяет, является ли одно
число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/
bool Sqrt(int firstNum, int secondNum)
{
    int firstNumSqrt = firstNum * firstNum;
    int secondNumSqrt = secondNum * secondNum;
    return (firstNumSqrt == secondNum || secondNumSqrt == firstNum);
};

Console.WriteLine("Введите первое число: ");
int userFirstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int userSecondNum = Convert.ToInt32(Console.ReadLine());

bool userResult = Sqrt(userFirstNum, userSecondNum);
Console.WriteLine(userResult ? "да" : "нет");