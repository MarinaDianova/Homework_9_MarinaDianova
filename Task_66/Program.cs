// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum(int numM, int numN)
{
    if (numN < numM)
    {
        return numN;
    }
    return numN + Sum(numM, numN - 1);

}

int m = ReadInt("Введите M: ");
int n = ReadInt("Введите N: ");

if (n <= m)
    System.Console.WriteLine($"Сумма натуральных чисел от {n} до {m} = {Sum(n, m)}");

else
    System.Console.WriteLine($"Сумма натуральных чисел от {m} до {n} = {Sum(m, n)}");
