/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.*/

Console.Write("Необходимо ввести трехзначное число: ");
while(true)
{
    string Number = Console.ReadLine();
    int Num = int.Parse(Number);
    if(Num > 99)
        Console.WriteLine($"{Num} -> {Number[2]}");
    else
        Console.WriteLine($"{Number} -> нет второго числа");
        break;
}