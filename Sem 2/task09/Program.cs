// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

// Метод Next возвращает целое положительное число от 0. 
// Если указать в скобках параметр - это макимальное значение из диапазона
// Два параметра (полуинтервал) : первый параметр входит, второй - нет

int randomNum = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка [10-99] : {randomNum}");

// int firstDigit = randomNum / 10;
// int secondDigit = randomNum % 10;
// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {randomNum} : {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа {randomNum} : {secondDigit}");

/* через тернарный оператор */
// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа {randomNum} : {maxDigit}");

// функции - метод, который ВОЗВРАЩАЕТ значение
// процедуры - метод, который НЕ ВОЗВРАЩАЕТ значение
// названия методов - с большой буквы

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    return maxDigit;
}

int result = MaxDigit(randomNum);
Console.WriteLine($"Наибольшая цифра числа {randomNum} : {result}");