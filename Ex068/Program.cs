// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите натуральное число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число n");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FunctionAkkerman(m, n));

int FunctionAkkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return FunctionAkkerman(n - 1, 1);
    else
      return FunctionAkkerman(n - 1, FunctionAkkerman(n, m - 1));
}