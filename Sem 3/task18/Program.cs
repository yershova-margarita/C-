/*
Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).
*/
string Quarter(int quarterNum){
    if (quarterNum == 1) return "x > 0 ,y > 0";
    if (quarterNum == 2) return "x < 0 ,y > 0";
    if (quarterNum == 3) return "x < 0 ,y < 0";
    if (quarterNum == 4) return "x > 0 ,y < 0";
    return "Введены некорректные данные";
}

Console.WriteLine("Введите номер четверти от 1 до 4:");
int userQuater = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Quarter(userQuater));
