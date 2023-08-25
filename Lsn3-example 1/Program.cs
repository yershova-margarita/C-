// Вид 1
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();

// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст ...");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст сообщения", count: 4); // Именованные аргументы: по порядку писать необязательно.
// Method21("Текст сообщения", 4);          // Неименованные аргументы - обязательно по порядку

// Вид 3
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4 
string Method4(int count, char text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, 'z');
Console.WriteLine(res);

string Method41(int count, char text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res1 = Method41(10, 'z');
Console.WriteLine(res1);
