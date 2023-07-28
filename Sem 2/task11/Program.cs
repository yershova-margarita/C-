/* Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого
числа.
456 -> 46
782 -> 72
918 -> 98
*/
int randomNum = new Random().Next(100,1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999: {randomNum}");
int result = DelSecondDigit(randomNum);
Console.WriteLine($"Результат удаления второй цифры : {result}");

int DelSecondDigit(int num) {
    int firstDigit = num / 100;
    // int secondDigit = num /10 % 10;
    int thirdDigit = num % 10;
    return firstDigit * 10 + thirdDigit;
}