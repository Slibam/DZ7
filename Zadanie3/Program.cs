void Zadanie36()
{
    int stroc = 4;
    int stolb = 4;
    int[,] array = new int[stroc, stolb];
    FilArray(array);
    PrintArrayMas(array);
}
void FilArray(int[,] array)
{
    //С помощью переменной s задаём числа начиная с 1.
    int s = 1;
    int stroc = 4;
    int stolb = 4;

    //Заполение массива по часовой стрелке.
    for (int y = 0; y < stolb; y++)
    {
        array[0, y] = s;
        s++;
    }
    for (int x = 1; x < stroc; x++)
    {
        array[x, stolb - 1] = s;
        s++;
    }
    for (int y = stolb - 2; y >= 0; y--)
    {
        array[stroc - 1, y] = s;
        s++;
    }
    for (int x = stroc - 2; x > 0; x--)
    {
        array[x, 0] = s;
        s++;
    }
    int c = 1;
    int d = 1;

    while (s < stroc * stolb)
    {
        //Движемся вправо.
        while (array[c, d + 1] == 0)
        {
            array[c, d] = s;
            s++;
            d++;
        }
        //Движемся вниз.
        while (array[c + 1, d] == 0)
        {
            array[c, d] = s;
            s++;
            c++;
        }
        //Движемся влево.
        while (array[c, d - 1] == 0)
        {
            array[c, d] = s;
            s++;
            d--;
        }
        //Движемся вверх.
        while (array[c - 1, d] == 0)
        {
            array[c, d] = s;
            s++;
            c--;
        }
    }
    for (int x = 0; x < stroc; x++)
    {
        for (int y = 0; y < stolb; y++)
        {
            if (array[x, y] == 0)
            {
                array[x, y] = s;
            }
        }
    }
}

void PrintArrayMas(int[,] array)
{
    int stroc = 4;
    int stolb = 4;
    for (int x = 0; x < stroc; x++)
    {
        for (int y = 0; y < stolb; y++)
        {
            if (array[x, y] < 10)
            {
                Console.Write(array[x, y] + "  ");
            }
            else
            {
                Console.Write(array[x, y] + " ");
            }
        }
        Console.WriteLine("");
    }
}
Zadanie36();

