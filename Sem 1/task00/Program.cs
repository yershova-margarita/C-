// напишите программу, которая на вход
// принимает число и выдаёт его квадрат
// (число, умноженное на само себя)
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sqrt = num * num;
Console.WriteLine($"Квадрат числа {num} равен {sqrt}"); // интерполяция строк