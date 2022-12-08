// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void Zadanie36()
{
    int stroc = 4;
    int stolb = 4;
    int[,] numbers = new int[stroc, stolb];
    FilArray(numbers);
    Console.WriteLine("До сортировки");
    PrintArrayMas(numbers);
    Sort2mer(numbers);
    Console.WriteLine("После сортировки по убыванию");
    PrintArrayMas(numbers);
}
void FilArray(int[,] numbers, int minRazmer = 0, int maxRazmer = 100)
{
    maxRazmer++;
    Random rand = new Random();
    int stroc = numbers.GetLength(0);
    int stolb = numbers.GetLength(1);
    for (int i = 0; i < stroc; i++)
    {
        for (int j = 0; j < stolb; j++)
        {
            numbers[i, j] = rand.Next(minRazmer, maxRazmer);
        }
    }
}
void PrintArrayMas(int[,] numbers)
{
    int stroc = numbers.GetLength(0);
    int stolb = numbers.GetLength(1);
    for (int i = 0; i < stroc; i++)
    {
        for (int j = 0; j < stolb; j++)
        {
            Console.Write($"{numbers[i, j]}\t");
        }
        Console.WriteLine();
    }
}
void Sort2mer(int[,] numbers)
{
    Console.WriteLine();
    int xx;
    int stroc = numbers.GetLength(0);
    int stolb = numbers.GetLength(1);
    for (int i = 0; i < stroc; i++)
    {
        for (int j = 0; j < stolb-1; j++)
        {
            for (int r = j + 1; r < stolb; r++)
            {
                if (numbers[i, j] < numbers[i, r])
                {
                    xx = numbers[i, j];
                    numbers[i, j] = numbers[i, r];
                    numbers[i, r] = xx;
                }
            }
        }
    }
}
Zadanie36();
