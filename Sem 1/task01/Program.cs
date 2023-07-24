// напишите программу, которая на вход
// принимает два числа и проверяет, 
// является ли первое число кваратом второго
Console.WriteLine("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
int sqrt = secondNum * secondNum;
if (sqrt == firstNum) 
{
    Console.WriteLine($"Число {firstNum} явяется квадратом числа {secondNum}");
}
else
{
    Console.WriteLine($"Число {firstNum} не явяется квадратом числа {secondNum}");
}