void CreateMatrix(char[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = "BW"[new Random().Next(0, 2)];
            Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine();
    }
}

void FindMistake(char[,] matrix, char[,] matrix2)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == matrix2[i, j]) count++;
        }
    }
    Console.WriteLine($"Количество неправильно сформированных пиктеселй:{count}");
}

Console.Clear();
Console.WriteLine("Введите количество строк n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов m: ");
int m = Convert.ToInt32(Console.ReadLine());
char[,] arr = new char[n, m];
CreateMatrix(arr);
Console.WriteLine();
char[,] newArr = new char[n, m];
CreateMatrix(newArr);
FindMistake(arr, newArr);
