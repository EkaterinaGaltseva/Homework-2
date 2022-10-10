/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/


Console.Write("Введите число дня недели: ");
while(true)
{
    string WeekDays = Console.ReadLine();
    int days = int.Parse(WeekDays);
    if(days == 6 || days == 7)
        Console.WriteLine($"{days} -> да");
    else
        Console.WriteLine($"{days} -> нет");
        break;
}