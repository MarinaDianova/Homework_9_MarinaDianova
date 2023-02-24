// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Akerman(int numM, int numN)
{
    if (numM == 0)
        return numN + 1;

    else if (numM != 0 && numN == 0)
        return Akerman(numM - 1, 1);

    else
        return Akerman(numM - 1, Akerman(numM, numN - 1));

}

metka:
int m = ReadInt("Введите m: ");
int n = ReadInt("Введите n: ");

if (m < 0 || n < 0)
{
    System.Console.WriteLine("Числа не должны быть меньше нуля!");
    goto metka;
}

System.Console.WriteLine($"A(m,n) = {Akerman(m, n)}");
