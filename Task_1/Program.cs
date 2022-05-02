// Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N в обратном порядке. 

Console.WriteLine("Задайте число M ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число M ");
int N = Convert.ToInt32(Console.ReadLine());
Recursion(M,N);
void Recursion(int m, int n)
{
    if (m == n) return;
    Recursion(m - 1, n);
}

//Вариант 2.

// Console.WriteLine("Задайте число ");
// int number = Convert.ToInt32(Console.ReadLine());
// Recursion(number);
// void Recursion(int n)
// {
//     if (n == 0) return;
//     Console.Write(n + " ");
//     Recursion(n - 1);
// }



