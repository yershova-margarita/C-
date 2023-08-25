// Дан текст. В тексте нужно все побелы заменить черточками,
// маленькие буквы "к" заменить большими "К", а большие "С"
// заменить маленькими "с"

// string s = "qwerty"
//             012345
// s[3]     // r - посимвольное обращение

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
         if (text[i] == oldValue) result = result+ $"{newValue}";
         else result = result + $"{text[i]}";
    }
    return result;
}

string userText = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string newText = Replace(userText, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'K');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);