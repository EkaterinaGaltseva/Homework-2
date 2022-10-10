/*Напишите программу, которая на вход принимает трехзначное число и на выход показывает вторую цифру этого числа 
Пример:
456->5 */
Console.Write("Необходимо ввести трехзначное число: ");
while(true)
{
    string Number = Console.ReadLine();
    if(!Number.Equals("exit"))
        Console.WriteLine("{0}->{1}", Number, Number[1]);
    else 
        Console.Write("Нажмите Enter для выхода");
        break;
}