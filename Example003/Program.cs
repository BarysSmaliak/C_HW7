// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int [,] CreateArray (int length1, int length2, int min, int max) 
{
    int [,] array = new int [length1, length2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void PrintArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}");
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

void ArithmeticMean (int [,] array)
{
    Console.WriteLine("Arithmetic mean is: "); 
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        double arithMeanColumn = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
            arithMeanColumn = Math.Round(sum/(i+1), 1);
        }
        Console.Write($" {arithMeanColumn};");
    }
}

int length1 = ReadInt("number of lines in the array 'm'");
int length2 = ReadInt("number of columns in the array 'n'");
int min = ReadInt("minimum value of an array element");
int max = ReadInt("maximum value of an array element");
int [,] Array = CreateArray(length1, length2, min, max);
PrintArray(Array);
Console.WriteLine();
ArithmeticMean(Array);