// Фибоначи

double Fibonachi (int n)
{
    if(n==1 || n==2) return 1;
    else return Fibonachi(n-1) + Fibonachi(n-2);
}

Console.WriteLine("Введите число: ");
int userNum = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < userNum; i++)
{
    Console.WriteLine($"f({i}) = {Fibonachi(i)}");
}