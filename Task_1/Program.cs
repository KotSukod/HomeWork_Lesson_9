//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string Sum(int a)
{
    if (a >= 1) return $"{a} " + Sum(a-1);
    else return String.Empty;
}
Console.WriteLine(Sum(num));