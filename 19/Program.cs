// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

if (num < 10000 && num > 99999) {
    System.Console.WriteLine("Это не 5-значное число");
    return;
}

if (num / 10000 == num % 10)
{
    if ((num / 1000) % 10 == (num % 100) / 10)
    {
        System.Console.WriteLine("да");
    }
}
else
{
    System.Console.WriteLine("нет");
}