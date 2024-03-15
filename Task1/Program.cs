// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

Console.WriteLine("Введите значение переменной M: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение переменной N: ");
int n = int.Parse(Console.ReadLine());

int getMinNumber(int x, int y)
{
    int min;

    if(x > y)
    {
        min = y;
    }
    else
    {
        min = x;
    }

    return min;
}

int getMaxNumber(int x, int y)
{
    int max;

    if(x > y)
    {
        max = x;
    }
    else
    {
        max = y;
    }

    return max;
}

int min = getMinNumber(m, n);
int max = getMaxNumber(m, n);

void PrintNumbers(int current, int limit)
{
    if(current > limit)
    {
        return;
    }

    Console.Write($"{current} ");
    PrintNumbers(current + 1, limit);

}

PrintNumbers(min, max);