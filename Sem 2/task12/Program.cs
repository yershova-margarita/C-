/* Напишите программу, которая будет принимать на
вход два числа и выводить, является ли первое число
кратным второму. Если первое число не кратно
второму, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/
Console.WriteLine("Введите первое число : ");
int userFirstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
int userSecondNum = Convert.ToInt32(Console.ReadLine());

int userResult = Remains(userFirstNum, userSecondNum);
if (userResult == 0) Console.WriteLine("Первое число кратно второму");
else Console.WriteLine($"Первое число не кратно второму, остаток {userResult}");

int Remains(int firstNum, int secondNum)
{
    int result = firstNum % secondNum == 0 ? 0 : firstNum % secondNum;
    return result;
}