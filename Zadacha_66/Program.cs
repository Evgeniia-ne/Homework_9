// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
int m = InputInt("Введите число M: ");
int n = InputInt("Введите число N: ");
Console.WriteLine($"Сумма элементов от {m} до {n} = {sum(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int sum(int m, int n)
{
    if (m == n)
        return n;
    return n + sum(m, n - 1);
}