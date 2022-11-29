// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int a = Convert.ToInt32(Console.ReadLine());
int i = a;
int b = 0;
while (i > 0)
{
    int c = i % 10;
    b = b * 10 + c;
    i = i / 10;
}
if (b == a)
    Console.WriteLine("Палиндром");
else
    Console.WriteLine("Не палиндром");