//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double [,] CreateArray (int length1, int length2, int min, int max)
{
    double [,] array = new double [length1, length2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * (max - min) + min;
        }
    }
    return array;
}

void PrintArray (double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {Math.Round(array[i, j], 2)}");
        }
        Console.WriteLine();
    }
}

int ReadInt (string arg)
{
    int num;
    Console.WriteLine($"Input {arg}: ");
    while (!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("it,s not a number. Input the correct number");
    }
    return num;
}

int length1 = ReadInt("number of rows in the array 'm'");
int length2 = ReadInt("number of columns in the array 'n'");
int min = ReadInt("minimum value of an array element");
int max = ReadInt("maximum value of an array element");
PrintArray(CreateArray(length1, length2, min, max));