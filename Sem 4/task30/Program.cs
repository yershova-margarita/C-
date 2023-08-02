/*
Напишите программу, которая выводит
массив из 8 элементов, заполненный нулями и
единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
        Console.Write(arr[i] + " ");
    }
}

int[] myArray = new int[8];     // массив c 0
FillArray(myArray);