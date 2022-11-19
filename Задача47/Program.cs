// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine();
Console.WriteLine("Программа получает размер двумерного массива m*n от пользователя и заполненяет его случайными вещественными числами");

uint rows;
uint columns;
RowsRead();
ColumnsRead();

double[,] array = CreateRandomArray(rows, columns);
PrintArray(array);



// Функция считывания количества строк из консоли
void RowsRead() 
{
    Console.WriteLine("Введите количество строк: ");
    while (!uint.TryParse(Console.ReadLine()!, out rows) || (rows == 0))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Неверный ввод");
        Console.ResetColor();
        Console.WriteLine("Введите количество строк: ");
    }
}

// Функция считывания количества столбцов из консоли
void ColumnsRead() 
{
    Console.WriteLine("Введите количество столбцов: ");
    while (!uint.TryParse(Console.ReadLine()!, out columns) || (columns == 0))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Неверный ввод");
        Console.ResetColor();
        Console.WriteLine("Введите количество столбцов: ");
    }
}

// Функция заполнения массива случайными числами
double[,] CreateRandomArray(uint rows, uint columns)   
{
    double[,] array = new double [rows, columns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = Math.Round(random.Next(0, 10) + random.NextDouble(), 1);
        }
    }
    return array;
}

// Функция вывода массива в консоль
void PrintArray(double[,] array)      
{
    Console.WriteLine();
    Console.WriteLine("Сгенерированный массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}