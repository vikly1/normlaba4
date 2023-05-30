using System.Drawing;
int line1 = 0;
int line2 = 0;
int col1 = 0;
int col2 = 0;
int[,,] array = { { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } } };
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            Console.WriteLine(array[i, j, k]);
        }
    }
}
start();
void start()
{
    Console.WriteLine("Введите количество строк первой матриы");
    line1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов первой матриы");
    col1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите количество строк второй матриы");
    line2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов второй матриы");
    col2 = int.Parse(Console.ReadLine());
}
int[,] matrix1 = new int[line1, col1];
int[,] matrix2 = new int[line2, col2];
int[,] result = new int[line1, col1];
if (line1 != line2 || col1 != col2)
{
    Console.WriteLine();
    Console.WriteLine("Ошибка, размеры матриц не совпадают, введите снова.");
    Console.WriteLine();
    start();
}
else
{
    checkmatrix();
}
void checkmatrix()
{
    Console.WriteLine("Введите элементы первой матрицы");
    for (int i = 0; i < line1; i++)
    {
        for (int j = 0; j < col1; j++)
        {
            matrix1[i, j] = int.Parse(Console.ReadLine());
        }
    }
    for (int i = 0; i < line1; i++)
    {
        for (int j = 0; j < col1; j++)
        {
            Console.Write($"{matrix1[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("Введите элементы второй матрицы");
    for (int i = 0; i < line2; i++)
    {
        for (int j = 0; j < col2; j++)

        {
            matrix2[i, j] = int.Parse(Console.ReadLine());
        }
    }
    for (int i = 0; i < line2; i++)
    {
        for (int j = 0; j < col2; j++)
        {
            Console.Write($"{matrix2[i, j]}  ");
        }
        Console.WriteLine();
    }
    selectprog();
}
void selectprog()
{
    Console.WriteLine("Выберите программу");
    Console.WriteLine("1 Сложение");
    Console.WriteLine("2 Вычитание");
    var progvalid = Console.ReadKey().Key;
    switch (progvalid)
    {
        case ConsoleKey.D1:
            Console.WriteLine("Ответ");
            plus();
            break;
        case ConsoleKey.D2:
            Console.WriteLine();
            minus();
            break;
        default:
            Console.WriteLine("Некорректный ввод. Нажмите на 1, или 2.");
            selectprog();
            break;
    }
}
void plus()
{
    int[,] result = new int[line1, col1];
    for (int i = 0; i < line1; i++)
    {
        for (int j = 0; j < col1; j++)
        {
            result[i, j] = matrix1[i, j] + matrix2[i, j];
        }
    }
    for (int i = 0; i < line1; i++)
    {
        for (int j = 0; j < col1; j++)
        {
            Console.Write($"{result[i, j]}  ");
        }
        Console.WriteLine();
    }
}
void minus()
{
    for (int i = 0; i < line1; i++)
    {
        for (int j = 0; j < col1; j++)
        {
            result[i, j] = matrix1[i, j] - matrix2[i, j];
        }
    }
    for (int i = 0; i < line1; i++)
    {
        for (int j = 0; j < col1; j++)
        {
            Console.Write($"{result[i, j]}  ");
        }
        Console.WriteLine();
    }
}