 /* Напишите программу, которая принимает на
вход число и проверяет, кратно ли оно
одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/
bool Multiplicity(int num) {
    return (num % 7 == 0 && num % 23 == 0);
}

Console.WriteLine("Введите число : ");
int userNum = Convert.ToInt32(Console.ReadLine());
bool userResult = Multiplicity(userNum);

Console.WriteLine(userResult ? "да" : "нет");