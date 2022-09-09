// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите цифру от 1 до 7, соответствующую дню недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0 && number < 8)
{
    if (number > 0 && number < 6)
    {
        Console.WriteLine("это рабочий день");
    }
    else
    Console.WriteLine("это выходной день");
}
else
{
    Console.WriteLine("цифра не соответствует условию");
}