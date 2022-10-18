// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
int Sum(int a, int b)
{   
    if (a > b ) return 0;
    else return a + Sum(a+1,b);
}
Console.WriteLine(Sum(m,n));

