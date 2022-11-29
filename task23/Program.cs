// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
for (double b = 1; b <= a;)
{
    Console.WriteLine(Math.Pow(b, 3));
    b = b + 1;
}