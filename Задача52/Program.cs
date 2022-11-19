// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine();
Console.WriteLine("Программа находит среднее арифметическое элементов в каждом столбце.");
Console.WriteLine();

uint rows;
uint columns;
RowsRead();
ColumnsRead();

int[,] array = CreateRandomArray(rows, columns);
PrintArray(array);
PrintArithmeticMean(array);

// Функция считывания количества строк из консоли
void RowsRead() 
{
    Console.WriteLine("Введите количество строк ");
    while (!uint.TryParse(Console.ReadLine()!, out rows) || (rows == 0))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Неверный ввод");
        Console.ResetColor();
        Console.WriteLine("Введите количество строк ");
    }
}

// Функция считывания количества столбцов из консоли
void ColumnsRead() 
{
    Console.WriteLine("Введите количество столбцов ");
    while (!uint.TryParse(Console.ReadLine()!, out columns) || (columns == 0))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Неверный ввод");
        Console.ResetColor();
        Console.WriteLine("Введите количество столбцов ");
    }
}

// Функция заполнения массива случайными числами
int[,] CreateRandomArray(uint rows, uint columns)   
{
    int[,] array = new int [rows, columns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = random.Next(1, 10);
        }
    }
    return array;
}

// Функция вывода массива в консоль
void PrintArray(int[,] array)      
{
    Console.WriteLine();
    Console.WriteLine("Сгенерированный массив ");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Функция вывода среднего арифметического
void PrintArithmeticMean(int[,] array)
{
   for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Среднее арефметическое {j + 1} столбца {Math.Round (sum / array.GetLength(0), 1)} ");
    }
}