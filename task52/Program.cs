void CreateMatrix(int[,] matrix)
{
    for(int i = 0; i<matrix.GetLength(0); i++){
        for(int j = 0; j<matrix.GetLength(1); j++){
            matrix[i,j] = new Random().Next(-10,11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void FindAverage(int[,] matrix)
{
    for(int j = 0; j<matrix.GetLength(1); j++){
        double average = 0;
        for(int i = 0; i<matrix.GetLength(0); i++){
                  average += matrix[i,j];
        }
        Console.WriteLine($"Среднее арифмиитическое столбца {j+1}: {Math.Round(average/matrix.GetLength(0),1)}; ");
    }
}

Console.Clear();
Console.WriteLine("Введите m (количество строк): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n (количество столбцов): ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m,n];
CreateMatrix(arr);
FindAverage(arr);
