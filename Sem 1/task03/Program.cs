// напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
int [] numArray = {1,2,3,4,5,6,7};
int [] num = numArray;
string [] weekDayArray = {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
int i = 0;
string weekDay = "пн";
Console.WriteLine("Введите число от 1 до 7");
int userNum = Convert.ToInt32(Console.ReadLine());
if (userNum > 7 || userNum < 1) {
    Console.WriteLine("Число не входит в диапазон от 1 до 7");
}
else {
    while (i < numArray.Length)
    {
        if (userNum == numArray[i]) {
            weekDay = weekDayArray[i];
            break;
        }
        i++;
    }
    Console.WriteLine($"{userNum} это {weekDay} ");
}