// Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void Zadanie36()
{
    int stroc = 4;
    int stolb = 4;
    int[,] numbers = new int[stroc, stolb];
    FilArray(numbers);
    PrintArrayMas(numbers);
    NahodNaimSumStroc(numbers);
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
void NahodNaimSumStroc(int[,] numbers)//Нахождение строки с наименьшей суммой элементов.
{
    Console.WriteLine();
    int stroc = numbers.GetLength(0);
    int stolb = numbers.GetLength(1);
    int Sum = 0;
    int y = 0;
    int x = 1000;
    for (int i = 0; i < stroc; i++)
    {
        for (int j = 0; j < stolb; j++)
        {
            Sum += numbers[i, j];
        }
        Console.WriteLine($"Сумма строки {i + 1}: {Sum}");
        if (x>Sum)
        {
            x = Sum;
            y = i+1;
        }
        Sum = 0;
    }
    Console.WriteLine();
    Console.WriteLine($"Номер строки с минимальной суммой элементов {y}, сумма данной строки = {x} ");
}
Zadanie36();