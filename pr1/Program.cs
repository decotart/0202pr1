void Solution(int[,] mas, out int aboveMain,
    out int belowMain, out int outsideSecondary)
{
    aboveMain = 0;
    belowMain = 0;
    outsideSecondary = 0;

    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            if (j > i && mas[i, j] == 0)
            {
                aboveMain++;
            }
            if (j < i && mas[i, j] == 0)
            {
                belowMain++;
            }
            if ((i + j != mas.GetLength(0) + 1) && mas[i, j] == 0)
            {
                outsideSecondary++;
            }

        }
    }
}

int sideSize;
int[,] mas;
Random rnd = new();

Console.WriteLine("Введите размер диагонали: ");

bool foo = int.TryParse(Console.ReadLine(), out sideSize);

if (foo)
{
    mas = new int[sideSize, sideSize];

    int above, under, outside;

    Console.WriteLine("\nМассив:");

    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i, j] = rnd.Next(0, 2);

            Console.Write($"{mas[i, j]} ");
        }
        Console.WriteLine();
    }

    Solution(mas, out above, out under, out outside);

    Console.WriteLine($"\nРезультаты:" +
        $"\nКол-во нулевых элементов выше главной диагонали: {above}" +
        $"\nКол-во нулевых элементов ниже главной диагонали: {under}" +
        $"\nКол-во нулевых элементов выше и ниже побочной диагонали: {outside}");
}
else
{
    Console.WriteLine("Принимаю только числа!");
}



