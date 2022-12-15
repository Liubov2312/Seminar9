// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n (m < n) ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(GetSum(m, n));

int GetSum(int start, int end)
{
    if (start == end)
    {
        return start;
    }
    return (end + GetSum(start, --end));
}

