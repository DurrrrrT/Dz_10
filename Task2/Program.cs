//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
//  в промежутке от M до N. M = 1; N = 15 -> 120 M = 4; N = 8. -> 30

Console.WriteLine("Задайте число M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число N ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int NaturalNum(int m, int n)
{
    if (m < n)
    {
        sum += m;
        NaturalNum(m + 1, n);
        return sum + n;
    }
    else if (m > n)
    {
        sum += n;
        NaturalNum(m, n + 1);
        return sum + m;
    }
    else return 0;
}
Console.WriteLine($"Сумма элементов равна: {NaturalNum(m,n)} ");
