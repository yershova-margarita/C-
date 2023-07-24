int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] myArray = { 11, 23, 56, 34, 65, 67, 7 ,78, 39 };

int max = Max(
    Max(myArray[0], myArray[1], myArray[2]),
    Max(myArray[3], myArray[4], myArray[5]),
    Max(myArray[6], myArray[7], myArray[8]));
Console.Write("Наибольшее число: " + max);